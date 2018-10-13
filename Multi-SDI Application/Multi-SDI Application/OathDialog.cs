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
    public partial class OathDialog : dialogBaseForm
    {
        public OathDialog()
        {
            InitializeComponent();
        }

        private void OathDialog_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(createBorder);
        }

        //Creates Gradient Brush that draws border in client
        private void createBorder(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, Color.SteelBlue, Color.LightBlue, 45);

            ColorBlend colorBlend = new ColorBlend(3); //ColorBlend needed to include more than 2 colors
            colorBlend.Colors = new Color[3] { Color.SteelBlue, Color.CadetBlue, Color.LightBlue};
            colorBlend.Positions = new float[3] { 0f, 0.5f, 1f };

            brush.InterpolationColors = colorBlend; //Changes brush to include all 3 colors

            e.Graphics.DrawRectangle(new Pen(brush, 10), ClientRectangle);
            brush.Dispose();
        }

        private void OathDialog_SizeChanged(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(createBorder);
        }
    }
}
