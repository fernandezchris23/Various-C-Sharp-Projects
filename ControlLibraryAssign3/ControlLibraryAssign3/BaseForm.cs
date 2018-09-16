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
    }
}
