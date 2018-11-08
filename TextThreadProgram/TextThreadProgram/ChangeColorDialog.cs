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
        private PictureBox pictureBox;
        public event EventHandler applyBttnClick;

        public ChangeColorDialog(PictureBox pictureBox)
        {
            InitializeComponent();
            this.pictureBox = pictureBox;
        }

        private void oldColorBttn_Click(object sender, EventArgs e)
        {
            // reset color label
            oldColorLabelDisplay.Text = "";
            ColorDialog dlg = new ColorDialog();
            Boolean IsColorFound = false;

            if (pictureBox.Image != null)
            {
                //Converting loaded image into bitmap
                Bitmap bmp = new Bitmap(pictureBox.Image);

                //Iterate whole bitmap to findout the picked color
                for (int i = 0; i < pictureBox.Image.Height; i++)
                {

                    for (int j = 0; j < pictureBox.Image.Width; j++)
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
                                oldColorLabelDisplay.Text = dlg.Color.ToString();
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

                MessageBox.Show("Image is not loaded");
            }

        }

        private void newColorBttn_Click(object sender, EventArgs e)
        {
            // reset color label
            newColorLabelDisplay.Text = "";

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
                    newColorLabelDisplay.Text = dlg.Color.ToString();
            }
        }

        private void okayColorBttn_Click(object sender, EventArgs e)
        {

        }

        private void colorApplyBttn_Click(object sender, EventArgs e)
        {

        }

        private void cancelColorBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
