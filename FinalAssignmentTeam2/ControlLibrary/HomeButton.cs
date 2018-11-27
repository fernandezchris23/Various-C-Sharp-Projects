using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ControlLibrary
{
    public partial class HomeButton : UserControl
    {
        private int width;
        private int height;
        public event EventHandler homeBttnClick;

        public HomeButton()
        {
            width = 512;
            height = 512;
            InitializeComponent();
        }

        private void HomeButton_Load(object sender, EventArgs e)
        {
            setEllipseRegion();
        }

        private void HomeButton_Resize(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
            setEllipseRegion();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Transparent;
            homeBttnClick(this, EventArgs.Empty);
        }

        private void setEllipseRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new RectangleF(-1, -1, width + 1, height + 1));
                this.Region = new Region(path);
            }
        }
    }
}
