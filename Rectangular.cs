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
using Assignment3;

namespace MainFormFiles
{
    public partial class Rectangular : BaseForm
    {
        public Rectangular(int height,double multiple)
        {
            this.height = height;
            this.width = (int) multiple * height;

            InitializeComponent();
            this.ClientSize = new System.Drawing.Size((int)multiple*height,
                height);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Gold;
        }

        void SetRectangleRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(this.ClientRectangle);
                this.Region = new Region(path);
            }
        }

        private int height;
        private int width;
    }
}
