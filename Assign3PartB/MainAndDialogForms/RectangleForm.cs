using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ControlLibraryAssign3;

namespace MainAndDialogForms
{
    public partial class RectangleForm : BaseForm
    {
        private int widthLocal;
        private int heightLocal;

        public RectangleForm(int height, float multiplier)
        {
            heightLocal = height;
            widthLocal = (int)(heightLocal * multiplier);

            InitializeComponent();
        }

        private void RectangleForm_Load(object sender, EventArgs e)
        {
            SetRectangleRegion();
        }

        void SetRectangleRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(new RectangleF(0,0,widthLocal,heightLocal));
                this.Region = new Region(path);
            }
        }
    }
}
