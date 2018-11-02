using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary;

namespace TextThreadProgram
{
    public partial class TextOptions : BaseDialogForm
    {

        Text textProperties;
        public TextOptions()
        {
            InitializeComponent();
        }

        public TextOptions(Text text)
        {
            textProperties = text;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyTextBox.ReadOnly = true;
            switch (comboBox1.Text)
            {
                case "Text":
                    propertyTextBox.Font = textProperties.TextFont;
                    propertyTextBox.Text = textProperties.StringText;
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Font":
                    propertyTextBox.Font = textProperties.TextFont;
                    propertyTextBox.Text = textProperties.TextFont.FontFamily.Name + ", " + textProperties.TextFont.Size;
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Text Color":
                    propertyTextBox.BackColor = textProperties.TextColor;
                    propertyTextBox.Text = "";
                    break;

                case "Background Color":
                    propertyTextBox.BackColor = textProperties.BgColor;
                    propertyTextBox.Text = "";
                    break;

                case "Z-Order":
                    propertyTextBox.BackColor = Color.White;
                    if (textProperties.Z_Order == 0)
                        propertyTextBox.Text = "Back";
                    else
                        propertyTextBox.Text = "Front";
                    break;

                case "Location":
                    propertyTextBox.Text = textProperties.TextLocation.ToString();
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Rotation":
                    propertyTextBox.Text = textProperties.Rotation.ToString();
                    propertyTextBox.BackColor = Color.White;
                    break;
            }

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Text Color":
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        propertyTextBox.BackColor = colorDialog.Color;
                    break;

                case "Background Color":
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        propertyTextBox.BackColor = colorDialog.Color;
                    break;

                case "Font":
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                        propertyTextBox.Font = fontDialog.Font;
                    break;

                case "Text":
                    propertyTextBox.ReadOnly = false;
                    break;

                case "Z-Order":
                    if (textProperties.Z_Order == 0)
                        propertyTextBox.Text = "Front";
                    else
                        propertyTextBox.Text = "Back";
                    break;
            }
        }

        /*
         * UpdateProperties will take String as an input and then update the corresponding
         * property on the textProperties object. This will send out a PropertyChanged event
         * that the main form has to catch somehow (it isn't catching it right now but i think
         * everything leading up to it is working)
         * 
         */
        private void UpdateProperties(String propName)
        {
            switch (propName)
            {
                case "Text":
                    textProperties.StringText = comboBox1.Text;
                    break;

                case "Font":
                    textProperties.TextFont = comboBox1.Font;
                    break;
                case "Text Color":
                    textProperties.TextColor = comboBox1.BackColor;
                    break;
                case "Background Color":
                    textProperties.BgColor = comboBox1.BackColor;
                    break;
                case "Z-Order":
                    if (comboBox1.Text == "Front")
                        textProperties.Z_Order = 1;
                    else
                        textProperties.Z_Order = 0;
                    break;

            }
        }

        /*
         * OkayButton and ApplyButton will both run UpdateProperties. OkayButton then closes the form
         */ 
        private void okayButton_Click(object sender, EventArgs e)
        {
            UpdateProperties(comboBox1.Text);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            UpdateProperties(comboBox1.Text);
        }
    }
}

