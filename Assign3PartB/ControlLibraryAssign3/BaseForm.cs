using System;
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

        // Color Dialog Context Menu Handler
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = baseFormColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = baseFormColorDialog.Color;
            }
        }

        // Close Context Menu Handler
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Mouse Down Handler for Movement of Shape
        public void Base_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            downPoint = new Point(e.X, e.Y);

        }

        // Mouse Move Handler for Movement of Shape
        public void Base_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
                return;

            Point location = new Point(this.Left + e.X - downPoint.X,
                    this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        // Mouse Up Handler for Movement of Shape
        public void Base_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            downPoint = Point.Empty;
        }

        Point downPoint = Point.Empty; //Point used for monitoring location of shape while moving
    }
}
