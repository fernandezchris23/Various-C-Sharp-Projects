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
        public Ellipse(int width, double multiple)
        {

            this.width = width;
            this.height = (int)(width * multiple);

            InitializeComponent();

            this.ClientSize = new Size(width, height);
            this.MouseDown += new MouseEventHandler(Base_MouseDown);
            this.MouseUp += new MouseEventHandler(Base_MouseUp);
            this.MouseMove += new MouseEventHandler(Base_MouseMove);
            
        }

        private int width;
        private int height;

        private void Ellipse_Load(object sender, EventArgs e)
        {
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

        private void Ellipse_SizeChanged(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }
        
    }

}
