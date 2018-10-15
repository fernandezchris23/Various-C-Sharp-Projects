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
    public partial class BaseMainForm : Form
    {
        public BaseMainForm()
        {
            InitializeComponent();
        }

        public virtual void oathToolStripMenuItem_Click(object sender, EventArgs e) {}

        public virtual void aboutToolStripMenuItem_Click(object sender, EventArgs e) {}

        public virtual void newWindowToolStripMenuItem_Click(object sender, EventArgs e) {}

        public virtual void saveToolStripMenuItem_Click(object sender, EventArgs e) {}

        public virtual void openToolStripMenuItem_Click(object sender, EventArgs e) {}
    }
}
