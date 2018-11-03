using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using ControlLibrary;

namespace TextThreadProgram
{
    public partial class TextOptions : BaseDialogForm
    {
        Text outOptions;
        public event EventHandler applyBttnClick;
        Binding binding;

        public TextOptions(Text text)
        {
            outOptions = text;
            InitializeComponent();
            propertyTextBox.Text = outOptions.StringText;
            outOptions.TextLocationX = outOptions.TextLocation.X;
            outOptions.TextLocationY = outOptions.TextLocation.Y;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Text":
                    propertyTextBox.DataBindings.Clear();
                    binding = new Binding("Text", outOptions, "StringText");
                    propertyTextBox.DataBindings.Add(binding);
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Font":
                    propertyTextBox.DataBindings.Clear();
                    binding = new Binding("Font", outOptions, "TextFont");
                    propertyTextBox.DataBindings.Add(binding);
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Text Color":
                    propertyTextBox.DataBindings.Clear();
                    binding = new Binding("ForeColor", outOptions, "TextColor");
                    propertyTextBox.DataBindings.Add(binding);
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Background Color":
                    propertyTextBox.DataBindings.Clear();
                    binding = new Binding("BackColor", outOptions, "BgColor");
                    propertyTextBox.DataBindings.Add(binding);
                    break;

                case "Z-Order":
                    propertyTextBox.DataBindings.Clear();
                    binding = new Binding("Text", outOptions, "Z_Order");
                    propertyTextBox.DataBindings.Add(binding);
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Location":
                    propertyTextBox.DataBindings.Clear();
                    binding = new Binding("Text", outOptions, "TextLocationX");
                    label1.DataBindings.Add(binding);
                    binding = new Binding("Text", outOptions, "TextLocationY");
                    label2.DataBindings.Add(binding);
                    propertyTextBox.Text = outOptions.TextLocationX + ", " + outOptions.TextLocationY;
                    propertyTextBox.BackColor = Color.White;
                    break;

                case "Rotation":
                    propertyTextBox.DataBindings.Clear();
                    binding = new Binding("Text", outOptions, "Rotation");
                    propertyTextBox.DataBindings.Add(binding);
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
                        outOptions.TextColor = colorDialog.Color;
                    propertyTextBox.ForeColor = outOptions.TextColor;
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
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Location")
            {
                updateLocation();
            }
            applyBttnClick(this, EventArgs.Empty);
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Location")
            {
                updateLocation();
            }
            applyBttnClick(this, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateLocation()
        {
            string[] coorParts = propertyTextBox.Text.Split(',');
            outOptions.TextLocationX = Int32.Parse(coorParts[0]);
            outOptions.TextLocationY = Int32.Parse(coorParts[1]);

            outOptions.TextLocation = new Point(outOptions.TextLocationX, outOptions.TextLocationY);
        }
    }
}

