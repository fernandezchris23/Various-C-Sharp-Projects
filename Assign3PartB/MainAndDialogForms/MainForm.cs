using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainAndDialogForms
{
    public partial class MainForm : Form
    {
        private PrefDialog prefDialog;
        private int rectHeightLocal;
        private int ellipWidthLocal;
        private float ratioLocal;
        private Stack<Ellipse> ellipseStack;
        private Stack<RectangleForm> rectangleFormStack;
        private bool prefDlgModelessClsd;
        private bool formIsClosing;

        public bool ShowLogin
        {
            get { return Properties.Settings.Default.SkipDialog; }
            set { Properties.Settings.Default.SkipDialog = (value); }
        }

        public MainForm()
        {
            InitializeComponent();
            this.closeEllipticToolStripMenuItem.Enabled = false;
            this.closeRectangularToolStripMenuItem.Enabled = false;
            ellipseStack = new Stack<Ellipse>();
            rectangleFormStack = new Stack<RectangleForm>();

            prefDlgModelessClsd = true; //Initially it is closed
            formIsClosing = false; //Used to prevent exception in deactivation
        }

        private void openPreferencesModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prefDialog = new PrefDialog();
            prefDialog.ShowDialog();

            SetVariables(prefDialog);
        }

        private void openPreferencesModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(prefDlgModelessClsd)
            {
                prefDialog = new PrefDialog();
                prefDialog.applyBttnClick += new EventHandler(prefDlgApplyClick);
                prefDialog.FormClosed += (s, arg) => prefDlgModelessClsd = true;
                prefDialog.Show();
                prefDlgModelessClsd = false;
            } 
        }

        public void SetVariables(PrefDialog prefDlg)
        {
            rectHeightLocal = prefDlg.RectHeight;
            ellipWidthLocal = prefDlg.EllipseWidth;
            ratioLocal = prefDlg.ShapeRatio;
        }

        private void prefDlgApplyClick(object sender, EventArgs e)
        {
            PrefDialog applyPrefDlg = sender as PrefDialog;
            SetVariables(applyPrefDlg);
        }

        private void openEllipticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ellipWidthLocal != 0 && ratioLocal != 0)
            {
                Ellipse ellipse = new Ellipse(ellipWidthLocal, ratioLocal);
                ellipse.MdiParent = this;
                ellipse.Show();
                ellipseStack.Push(ellipse);
                this.closeEllipticToolStripMenuItem.Enabled = true;
            }
        }

        private void openRectangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rectHeightLocal != 0 && ratioLocal != 0)
            {
                RectangleForm rectangleForm = new RectangleForm(rectHeightLocal, ratioLocal);
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
            formIsClosing = true;
            e.Cancel = ExitPrompt();
        }

        private Boolean ExitPrompt()
        {
            return MessageBox.Show("Exit", "Are you sure you want to exit?", MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if(!formIsClosing)
            {
                this.Opacity = 0.5;
            }
        }

        private void resetLoginScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLogin = false; 
            Properties.Settings.Default.Save();
        }

        // try to change the setting menu to not show
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ShowLogin == true) // if skipping is wanted
                settingsToolStripMenuItem.Visible = true; // don't show item if the 
            else // if skipping is not wanted  
                settingsToolStripMenuItem.Visible = false;
        }
    }
}
