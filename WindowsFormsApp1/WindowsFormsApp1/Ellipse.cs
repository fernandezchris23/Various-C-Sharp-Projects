using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Ellipse : Form
    {
 
        public Ellipse(int width, double height_multiplier)
        {
            this.Width = width;
            this.Height = (int) (width * height_multiplier);

            

        }
    }
}