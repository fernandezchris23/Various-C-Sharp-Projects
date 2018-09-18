using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment3A
{
	partial class Ellipse : Form
    {
		public Ellipse (int width, double height_multiplier)
        {
            this.Width = width;
            this.Height = (int)(width * height_multiplier);

            InitializeComponent();

            this.ClientSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.None;

            DrawEllipse();

        }

		void DrawEllipse()
        {
            SolidBrush brush = new SolidBrush(Blue);
            Rectangle rectangle = this.ClientRectangle;
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllpise(brush, rectangle);

        }

        void LoadEllipse(object sender, EventArgs e)
        {
            DrawEllipse();
        }
    }
}