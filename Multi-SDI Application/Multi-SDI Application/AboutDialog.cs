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
using ControlLibrary;

namespace Multi_SDI_Application
{
    public partial class AboutDialog : dialogBaseForm
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        //Used to fill background with tiled gradients
        private void createBG(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath(); //Created graphics path 1/4 the size of the form
            path.AddRectangle(new RectangleF(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2));

            PathGradientBrush brush = new PathGradientBrush(path); //Path brush used to create gradient and fill background

            brush.CenterColor = Color.SteelBlue;

            Color[] colors = { Color.CadetBlue };
            brush.SurroundColors = colors;

            brush.WrapMode = WrapMode.Tile;
            e.Graphics.FillRectangle(brush, new RectangleF(0, 0, ClientRectangle.Width, ClientRectangle.Height));

        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(createBG);
        }

        private void AboutDialog_SizeChanged(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(createBG);
        }
    }
}
