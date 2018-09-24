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
    public partial class CustomChild : BaseForm
    {
        private int widthLocal;
        private int heightLocal;

        public CustomChild(int width, float multiple)
        {
            widthLocal = width;
            heightLocal = (int)(width * multiple);

            InitializeComponent();
        }



        private void CustomChild_Load(object sender, EventArgs e)
        {
            SetRectangleRegion();
            SetEllipseRegion();
        }

        private void CustomChild_StyleChanged(object sender, EventArgs e)
        {
            SetRectangleRegion();
            SetEllipseRegion();
            SetPolygonegion();
        }

        void SetEllipseRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new RectangleF(0, 0, heightLocal, widthLocal));
                this.Region = new Region(path);
            }
        }


        void SetRectangleRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(new RectangleF(0, 0, widthLocal, heightLocal));
                this.Region = new Region(path);
            }
        }
        void SetPolygonegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = this.ClientRectangle;

                Point top = new Point(rect.X + widthLocal / 2, rect.Y);
                Point right = new Point(rect.X + widthLocal, rect.Y + heightLocal);
                Point left = new Point(rect.X, rect.Y + heightLocal);

                Point[] polyPoints = 
                {
                    top,
                    left,
                    right
                };

                path.AddPolygon(polyPoints);
                this.Region = new Region(path);
            }
        }
    }
}
