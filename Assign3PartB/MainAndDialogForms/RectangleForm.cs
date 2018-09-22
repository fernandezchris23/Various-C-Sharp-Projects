using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ControlLibraryAssign3;

namespace MainAndDialogForms
{
    public partial class RectangleForm : BaseForm
    {

        private int width;
        private int height;


        public RectangleForm(int height, float multiplier)
        {
            this.height = height;
            this.width = (int)(height * multiplier);

            InitializeComponent();

            this.ClientSize = new Size(width, height);
            this.MouseDown += new MouseEventHandler(Base_MouseDown);
            this.MouseUp += new MouseEventHandler(Base_MouseUp);
            this.MouseMove += new MouseEventHandler(Base_MouseMove);
        }

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
