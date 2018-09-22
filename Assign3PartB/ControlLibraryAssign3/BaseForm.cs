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

        //Color Dialog Context Menu Handler
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = baseFormColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = baseFormColorDialog.Color;
            }
        }

        //Close Context Menu Handler
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Mouse Down Handler for Movement of Shape
        public void Base_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            downOffset = new Size(e.X, e.Y);
        }

        //Mouse Move Handler for Movement of Shape
        public void Base_MouseMove(object sender, MouseEventArgs e)
        {
            if (downOffset == Size.Empty) //If there was no down, then don't try to move
                return;

            this.Location = MdiParent.PointToClient(Cursor.Position) - downOffset; //Takes cursor position and subtracts offset to move form smoothly
        }

        //Mouse Up Handler for Movement of Shape
        public void Base_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            downOffset = Size.Empty;
        }

        Size downOffset; //Offset used for moving
    }
}
