    using System;
    using System.Drawing;
    using System.Windows.Forms;

namespace Assignment3A
{
	partial class Rectangle : Form
    {
        public Rectangle(int width, double height_multiplier)
        {
            this.Width = width;
            this.Height = (int)(width * height_multiplier);

            InitializeComponent();

            this.ClientSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Red;

        }
    }
}