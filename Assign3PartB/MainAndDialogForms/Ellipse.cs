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
using ControlLibraryAssign3;

namespace MainAndDialogForms
{
    public partial class Ellipse : BaseForm
    {
        private int widthLocal;
        private int heightLocal;

        public Ellipse(int width, float multiple)
        {
            this.widthLocal = width;
            this.heightLocal = (int)(widthLocal * multiple);

            InitializeComponent();
        }

        private void Ellipse_Load(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }

        void SetEllipseRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new RectangleF(0,0, heightLocal, widthLocal));
                this.Region = new Region(path);
            }
        }
    }
}
