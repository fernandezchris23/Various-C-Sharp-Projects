using System;
using System.Windows.Forms;
using ControlLibraryAssign3;

namespace SDI_Text_Editor
{
    public partial class PrefsDialog : DialogBaseForm
    {
        EditorForm parentForm;
        TextProperties properties = new TextProperties();

        public PrefsDialog()
        {
            InitializeComponent();
        }

        //Overloaded constructor with parent and inherited text properties
        public PrefsDialog(EditorForm parent, TextProperties properties)
        {
            //Set parerntForm for future use
            /*NOTES: I think this can be done in a much better way, encapsulation and OOP-wise.
             * Create a single public method with return type TextProperties. This would include 
             * ShowDialog() and do everything just like this: open color, font dialogs and then
             * when closing, unless we close with the okayButton, all changes will be reverted
             * (save the previous TextProperties as oldProperties or something), otherwise return
             * the TextProperties parameter with the changes made.
             */
            parentForm = parent;
            InitializeComponent();
            UpdateCurrentProperties(properties);
            UpdateCurrentFontBox(properties);
            UpdateBackColorTextBox(properties);
        }

        //Update the current TextProperties for the preferences dialog to use and return
        public void UpdateCurrentProperties(TextProperties newProperties)
        {
            this.properties.textFont = newProperties.textFont;
            this.properties.textColor = newProperties.textColor;
            this.properties.backColor = newProperties.backColor;
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

        private void okayButton_Click(object sender, EventArgs e)
        {
            //TO DO: Validate colors

            //Update values on parent form (see notes on constructor) and close
            parentForm.UpdateValues(this.properties);
            this.Close();
        }

        //Change font button triggers the fontDialog
        private void changeFontButton_Click(object sender, EventArgs e)
        {
            //Show fontDialog, if result is OK then update properties and text box
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.properties.textColor = fontDialog.Color;
                this.properties.textFont = fontDialog.Font;
                this.UpdateCurrentFontBox(properties);
            }
        }


        public TextProperties TextProperties
        {
            get { return properties; }
            set { properties = value; }
        }

        //Change background button triggers the colorDialog
        private void changeBackgroundColorButton_Click(object sender, EventArgs e)
        {
            //If colorDialog result is OK, then update the background color and the text box        
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.properties.backColor = colorDialog.Color;
                UpdateBackColorTextBox(properties);
            }
        }
    }
}
