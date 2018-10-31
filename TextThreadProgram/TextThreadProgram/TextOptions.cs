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
        Text inOptions;
        Text outOptions;
        public TextOptions()
        {
            InitializeComponent();
        }

        public TextOptions(Text text)
        {
            inOptions = text;
            outOptions = text;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedText)
            {
                case "Text":
                    propertyTextBox.Font = outOptions.TextFont;
                    propertyTextBox.Text = outOptions.StringText;
                    break;

                case "Font":
                    propertyTextBox.Font = outOptions.TextFont;
                    propertyTextBox.Text = outOptions.TextFont.ToString();
                    break;

                case "Text Color":
                    propertyTextBox.BackColor = outOptions.TextColor;
                    break;

                case "Background Color":
                    propertyTextBox.BackColor = outOptions.BgColor;
                    break;

                case "Z-Order":
                    if (outOptions.Z_Order == 0)
                        propertyTextBox.Text = "Back";
                    else
                        propertyTextBox.Text = "Front";
                    break;

                case "Location":
                    propertyTextBox.Text = outOptions.TextLocation.ToString();
                    break;

                case "Rotation":
                    propertyTextBox.Text = outOptions.Rotation.ToString();
                    break;
            }
                    
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedText)
            {
                case "Text Color":
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        outOptions.TextColor = colorDialog.Color;
                    propertyTextBox.BackColor = outOptions.TextColor;
                    break;

                case "Background Color":
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        outOptions.BgColor = colorDialog.Color;
                    propertyTextBox.BackColor = outOptions.BgColor;
                    break;

                case "Font":
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                        outOptions.TextFont = fontDialog.Font;
                    propertyTextBox.Font = outOptions.TextFont;
                    break;

                case "Text":
                    propertyTextBox.ReadOnly = false;
                    break;

                case "Z-Order":
                    if (outOptions.Z_Order == 0)
                    {
                        outOptions.Z_Order = 1;
                        propertyTextBox.Text = "Front";
                    }
                    else
                    {
                        outOptions.Z_Order = 0;
                        propertyTextBox.Text = "Back";
                    }
                    break;
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {


            this.Close();
        }
    }
}

