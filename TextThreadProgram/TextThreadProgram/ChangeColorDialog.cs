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
    public partial class ChangeColorDialog : BaseDialogForm
    {
        private Bitmap im;
        public event EventHandler<ColorEventArgs> colors;
        public event EventHandler saveColors;

        public ChangeColorDialog(string filename)
        {
            InitializeComponent();
            im = new Bitmap(filename);
        }

        private void oldColorBttn_Click(object sender, EventArgs e)
        {
            // reset color label
            oldColorLabelDisplay.Text = "";
            oldColorLabelDisplay.BackColor = Color.White;

            ColorDialog dlg = new ColorDialog();
            DialogResult result = dlg.ShowDialog();
            Boolean IsColorFound = false;

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (im != null)
                {
                    //Converting loaded image into bitmap
                    Bitmap bmp = im;

                    int hello = bmp.Height;

                    //Iterate whole bitmap to findout the picked color
                    for (int i = 0; i < bmp.Height; i++)
                    {
                        for (int j = 0; j < bmp.Width; j++)
                        {
                            //Get the color at each pixel
                            Color nowColor = bmp.GetPixel(j, i);

                            //Compare Pixel's Color ARGB property with the picked color's ARGB property 
                            if (nowColor.ToArgb() == dlg.Color.ToArgb())
                            {
                                IsColorFound = true;

                                if (dlg.Color.IsKnownColor == true)
                                {
                                    oldColorLabelDisplay.BackColor = dlg.Color;
                                    oldColorLabelDisplay.Text = dlg.Color.ToKnownColor().ToString();
                                }
                                else
                                {
                                    oldColorLabelDisplay.BackColor = dlg.Color;
                                    oldColorLabelDisplay.Text = dlg.Color.ToString();
                                }
                                break;
                            }
                        }
                        if (IsColorFound == true)
                        {
                            break;
                        }
                    }
                    if (IsColorFound == false)
                    {
                        MessageBox.Show("Selected Color Not Found, try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Image is not loaded.");
                }
            }

        }

        private void newColorBttn_Click(object sender, EventArgs e)
        {
            // reset color label
            newColorLabelDisplay.Text = "";
            newColorLabelDisplay.BackColor = Color.White;

            ColorDialog dlg = new ColorDialog();
            DialogResult result = dlg.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //If it is know color, display the color name  

                if (dlg.Color.IsKnownColor == true)
                {
                    newColorLabelDisplay.BackColor = dlg.Color;
                    newColorLabelDisplay.Text = dlg.Color.ToKnownColor().ToString();
                }
                else
                {
                    newColorLabelDisplay.BackColor = dlg.Color;
                    newColorLabelDisplay.Text = dlg.Color.ToString();
                }
            }
        }

        private void okayColorBttn_Click(object sender, EventArgs e)
        {
            colors(this, new ColorEventArgs(oldColorLabelDisplay.BackColor, newColorLabelDisplay.BackColor));
            saveColors(this, EventArgs.Empty);
            this.Close();
        }

        private void colorApplyBttn_Click(object sender, EventArgs e)
        {
            colors(this, new ColorEventArgs(oldColorLabelDisplay.BackColor, newColorLabelDisplay.BackColor));
            saveColors(this, EventArgs.Empty);
        }

        private void cancelColorBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ColorEventArgs : EventArgs
    {
        public Color oldColorPass { get; set; }
        public Color newColorPass { get; set; }

        public ColorEventArgs(Color oldCol, Color newCol)
        {
            oldColorPass = oldCol;
            newColorPass = newCol;
        }
    }
}
