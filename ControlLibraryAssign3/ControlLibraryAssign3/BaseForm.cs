﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibraryAssign3
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = baseFormColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = baseFormColorDialog.Color;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Base_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            downPoint = new Point(e.X, e.Y);

        }

        public void Base_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
                return;

            Point location = new Point(this.Left + e.X - downPoint.Y,
                    this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        public void Base_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            downPoint = Point.Empty;
        }

        Point downPoint = Point.Empty;
    }
}