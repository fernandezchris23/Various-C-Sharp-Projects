using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainAndDialogForms
{
    public partial class MainForm : Form
    {
        private PrefDialog prefDialog;
        private int rectHeight;
        private int ellipWidth;
        private float ratio;
        private Stack<Ellipse> ellipseStack;
        private Stack<RectangleForm> rectangleFormStack;

        public MainForm()
        {
            InitializeComponent();
            this.closeEllipticToolStripMenuItem.Enabled = false;
            this.closeRectangularToolStripMenuItem.Enabled = false;
            ellipseStack = new Stack<Ellipse>();
            rectangleFormStack = new Stack<RectangleForm>();
        }

        private void openPreferencesModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prefDialog = new PrefDialog();
            prefDialog.ShowDialog();

            SetVariables(prefDialog);
        }

        private void openPreferencesModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prefDialog = new PrefDialog(this);
            prefDialog.Show();
        }

        public void SetVariables(PrefDialog prefDialog)
        {
            if(prefDialog != null)
            {
                rectHeight = prefDialog.RectHeight;
                ellipWidth = prefDialog.EllipseWidth;
                ratio = prefDialog.ShapeRatio;
            }
        }

        private void openEllipticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ellipWidth != 0 && ratio != 0)
            {
                Ellipse ellipse = new Ellipse(ellipWidth, ratio);
                ellipse.MdiParent = this;
                ellipse.Show();
                ellipseStack.Push(ellipse);
                this.closeEllipticToolStripMenuItem.Enabled = true;
            }
        }

        private void openRectangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rectHeight != 0 && ratio != 0)
            {
                RectangleForm rectangleForm = new RectangleForm(rectHeight, ratio);
                rectangleForm.MdiParent = this;
                rectangleForm.Show();
                rectangleFormStack.Push(rectangleForm);
                this.closeRectangularToolStripMenuItem.Enabled = true;
            }
        }

        private void closeEllipticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while(ellipseStack.Count > 0)
                ellipseStack.Pop().Close();
            
            if(ellipseStack.Count == 0)
                this.closeEllipticToolStripMenuItem.Enabled = false;

        }

        private void closeRectangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (rectangleFormStack.Count > 0)
                rectangleFormStack.Pop().Close();

            if (rectangleFormStack.Count == 0)
                this.closeRectangularToolStripMenuItem.Enabled = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitPrompt())
                this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = ExitPrompt();
        }

        private Boolean ExitPrompt()
        {
            return MessageBox.Show("Exit", "Are you sure you want to exit?", MessageBoxButtons.YesNo) == DialogResult.No;
        }
    }
}
