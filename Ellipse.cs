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
            this.BackColor = System.Drawing.Color.Red;

            SetEllipseRegion();

        }

        void SetEllipseRegion()
        {
            Rectangle rectangle = this.ClientRectangle;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rectangle);
                this.Region = new Region(path);
            }
        }

        void LoadEllipse(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }

        void EllipseSizeChanged(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }

        /*  Not how the book does this, seemed interesting and fairly simple so I left it here
		void DrawEllipse()
        {
            SolidBrush brush = new SolidBrush(Blue);
            Rectangle rectangle = this.ClientRectangle;
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllpise(brush, rectangle);
        }
        */
    }
}