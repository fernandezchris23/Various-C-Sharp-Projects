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
    public partial class RectangleForm : BaseForm
    {
        public RectangleForm(int height, double multiplier)
        {
            this.height = height;
            this.width = (int)(height * multiplier);

            InitializeComponent();

            this.MouseDown += new MouseEventHandler(Base_MouseDown);
            this.MouseUp += new MouseEventHandler(Base_MouseUp);
            this.MouseMove += new MouseEventHandler(Base_MouseMove);
        }

        private int width;
        private int height;

        private void RectangleForm_Load(object sender, EventArgs e)
        {
            SetRectangleRegion();
        }

        private void RectangleForm_StyleChanged(object sender, EventArgs e)
        {
            SetRectangleRegion();
        }

        void SetRectangleRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(this.ClientRectangle);
                this.Region = new Region(path);
            }
        }
    }
}
