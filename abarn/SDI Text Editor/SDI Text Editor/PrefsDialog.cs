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

        public PrefsDialog(EditorForm parent, TextProperties properties)
        {
            parentForm = parent;
            InitializeComponent();
            UpdateCurrentFontBox(properties);
        }

        public void UpdateCurrentProperties(TextProperties newProperties)
        {
            this.properties.textFont = newProperties.textFont;
            this.properties.textColor = newProperties.textColor;
            this.properties.bgColor = newProperties.bgColor;
        }

        public void UpdateCurrentFontBox(TextProperties newProperties)
        {
            this.currentFontTextBox.Font = newProperties.textFont;
            this.currentFontTextBox.Text = newProperties.textFont.Name + ", " +
                newProperties.textFont.Size;
            this.currentFontTextBox.ForeColor = newProperties.textColor;
        }


        public void UpdateBackColorTextBox(TextProperties newProperties)
        {
            this.backColorBox.BackColor = newProperties.bgColor;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            //TO DO: Validate info
            parentForm.UpdateValues(this.properties);
            this.Close();
        }

        private void changeFontButton_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog.ShowDialog();

            if (result == DialogResult.OK)
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

        private void changeBackColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.properties.bgColor = colorDialog.Color;
                UpdateBackColorTextBox(properties);
            }
        }
    }
}
