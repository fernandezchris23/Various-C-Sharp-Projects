﻿using System;
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
            SetCustomRegion();
        }

        private void CustomChild_StyleChanged(object sender, EventArgs e)
        {

        }

        void SetCustomRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                Point top = new Point(0 + widthLocal / 2, 0);
                Point right = new Point(0 + widthLocal, 0 + heightLocal);
                Point left = new Point(0, 0 + heightLocal);

                Point[] polyPoints =
                {
                    top,
                    left,
                    right
                };

                path.AddPolygon(polyPoints);
                path.AddEllipse(new RectangleF(0, 0, heightLocal, widthLocal));
                path.AddRectangle(new RectangleF(0, 0, widthLocal, heightLocal));
                this.Region = new Region(path);
            }
        }

    }
}
