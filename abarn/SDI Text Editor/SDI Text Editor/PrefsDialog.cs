using System;
using System.Windows.Forms;
using System.Drawing;
using ControlLibraryAssign3;

namespace SDI_Text_Editor
{
    public partial class PrefsDialog : DialogBaseForm
    {
        private TextProperties formProperties; //Used for accessing properties file shared between dialog and main
        public event EventHandler applyBttnClick; //Event for apply button

        public PrefsDialog()
        {
            InitializeComponent();
        }

        //Overloaded constructor with inherited text properties
        public PrefsDialog(TextProperties properties)
        {
            formProperties = properties;
            InitializeComponent();
            UpdateCurrentProperties(formProperties);
            UpdateCurrentFontBox(formProperties);
            UpdateBackColorTextBox(formProperties);
        }

        //Update the current TextProperties for the preferences dialog to use and return
        public void UpdateCurrentProperties(TextProperties newProperties)
        {
            this.formProperties.textFont = newProperties.textFont;
            this.formProperties.textColor = newProperties.textColor;
            this.formProperties.backColor = newProperties.backColor;
        }

        //Update the current font box
        public void UpdateCurrentFontBox(TextProperties newProperties)
        {
            this.currentFontTextBox.Font = newProperties.textFont;
            //Font's ToString() method returns a very long string. So just take name/size
            this.currentFontTextBox.Text = newProperties.textFont.Name + ", " +
                newProperties.textFont.Size;
            //ForeColor of textBox is the actual text color
            this.currentFontTextBox.ForeColor = newProperties.textColor;
        }

        //Update the background color of the current background text box
        public void UpdateBackColorTextBox(TextProperties newProperties)
        {
            this.backColorBox.BackColor = newProperties.backColor;
        }

        //Ok button handler which sends out a signal to the main form so that it updates its values
        private void okayButton_Click(object sender, EventArgs e)
        {
            if(validateContrast(formProperties.textColor, formProperties.backColor))
            {
                errorProvider.Clear();
                applyBttnClick(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                errorProvider.SetError(cancelButton, "Font Color and Background Color do not contrast enough. Please choose a different color.");
            }
        }

        //Apply button handler which sends out a signal to the main form so that it updates its values
        private void applyBttn_Click(object sender, EventArgs e)
        {
            if (validateContrast(formProperties.textColor, formProperties.backColor))
            {
                errorProvider.Clear();
                applyBttnClick(this, EventArgs.Empty);
            }
            else
            {
                errorProvider.SetError(cancelButton, "Font Color and Background Color do not contrast enough. Please choose a different color.");
            }
        }

        //Cancel Button handler
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Change font button triggers the fontDialog
        private void changeFontButton_Click(object sender, EventArgs e)
        {
            //Show fontDialog, if result is OK then update properties and text box
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.formProperties.textColor = fontDialog.Color;
                this.formProperties.textFont = fontDialog.Font;
                this.UpdateCurrentFontBox(formProperties);
            }
        }

        //Change background button triggers the colorDialog
        private void changeBackgroundColorButton_Click(object sender, EventArgs e)
        {
            //If colorDialog result is OK, then update the background color and the text box        
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.formProperties.backColor = colorDialog.Color;
                UpdateBackColorTextBox(formProperties);
            }
        }

        //Will return whether the contrast level passed the test or not
        public bool validateContrast(Color a, Color b)
        {
            int contrastValue;

            //This is a slightly modified algorithm Chris found online for determining color contrast
            //Based on what the person who developed it explained, getting a 100 means the colors are identical while a 0 is completely different
            contrastValue = (int)(100 * (1.0 - ((double)(Math.Abs(a.R - b.R) + Math.Abs(a.G - b.G) + Math.Abs(a.B - b.B)) / (256.0 * 3))));

            //Chris decided that 60 was a good value to use, through trial and error, to ensure a readable contrast
            if(contrastValue < 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
