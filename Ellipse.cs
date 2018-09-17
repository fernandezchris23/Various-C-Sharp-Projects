using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFormFiles
{
    public partial class Ellipse : Form
    {
        public Ellipse(double multiplier, int width)
        {
            this.width = width;
            this.height = (int)(width * multiplier);

            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(width, height);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Aqua;
            
            SetEllipseRegion();
        }
        void SetEllipseRegion()
        {

            Rectangle rect = this.ClientRectangle;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);
            }

        }

        void Ellipse_Load(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }
        void Ellipse_SizeChanged(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }

        void Ellipse_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            downPoint = new Point(e.X, e.Y);

        }

        void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
                return;

            Point location = new Point(this.Left + e.X - downPoint.Y,
                    this.Top + e.Y - downPoint.Y);
        }

        void Ellipse_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            downPoint = Point.Empty;
        }

        Point downPoint = Point.Empty;
        private int height;
        private int width;
    }
}
