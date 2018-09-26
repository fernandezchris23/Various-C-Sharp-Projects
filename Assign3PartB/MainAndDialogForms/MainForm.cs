using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using ControlLibraryAssign3;

namespace MainAndDialogForms
{
    public partial class MainForm : Form
    {
        private PrefDialog prefDialog;
        private OathDialog oathDialog;
        private int rectHeightLocal;
        private int ellipWidthLocal;
        private float ratioLocal;
        private Stack<Ellipse> ellipseStack;
        private Stack<RectangleForm> rectangleFormStack;
        private Stack<CustomChild> customChildStack;

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
            this.closeCustomToolStripMenuItem.Enabled = false;
            this.closeAllToolStripMenuItem.Enabled = false;

            this.openEllipticToolStripMenuItem.Enabled = false;
            this.openRectangularToolStripMenuItem.Enabled = false;
            this.openCustomToolStripMenuItem.Enabled = false;

            ellipseStack = new Stack<Ellipse>();
            rectangleFormStack = new Stack<RectangleForm>();
            customChildStack = new Stack<CustomChild>();

            prefDlgModelessClsd = true; //Initially it is closed
            formIsClosing = false; //Used to prevent exception in deactivation

            ellipWidthLocal = 0;
            rectHeightLocal = 0;
            ratioLocal = 0;
        }

        private void openPreferencesModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prefDialog = new PrefDialog();
            prefDialog.Owner = this;        // the main form is the owner of the preference dialog             

            prefDialog.RectHeight = rectHeightLocal;
            prefDialog.EllipseWidth = ellipWidthLocal;
            prefDialog.ShapeRatio = ratioLocal;

            prefDialog.ShowDialog();

            SetVariables(prefDialog);
            this.openRectangularToolStripMenuItem.Enabled = true; 
            this.openEllipticToolStripMenuItem.Enabled = true;
            this.openCustomToolStripMenuItem.Enabled = true;
            this.closeAllToolStripMenuItem.Enabled = true;
        }

        private void openPreferencesModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(prefDlgModelessClsd)
            {
                prefDialog = new PrefDialog();
                prefDialog.Owner = this;        // the main form is the owner of the preference dialog

                prefDialog.RectHeight = rectHeightLocal;
                prefDialog.EllipseWidth = ellipWidthLocal;
                prefDialog.ShapeRatio = ratioLocal;

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
            this.openRectangularToolStripMenuItem.Enabled = true;
            this.openEllipticToolStripMenuItem.Enabled = true;
            this.openCustomToolStripMenuItem.Enabled = true;
            this.closeAllToolStripMenuItem.Enabled = true;
        }

        private void openEllipticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ellipWidthLocal != 0 && ratioLocal != 0)
            {
                Ellipse ellipse = new Ellipse(ellipWidthLocal, ratioLocal);
                ellipse.MdiParent = this;
                EventHandler childChanged = new EventHandler(childChangeHandler);
                ellipse.BackColorChanged += childChanged;
                ellipse.Show();
                ellipseStack.Push(ellipse);
                this.closeEllipticToolStripMenuItem.Enabled = true;
                this.closeAllToolStripMenuItem.Enabled = true;
            }
        }

        private void openRectangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rectHeightLocal != 0 && ratioLocal != 0)
            {
                RectangleForm rectangleForm = new RectangleForm(rectHeightLocal, ratioLocal);
                rectangleForm.MdiParent = this;
                EventHandler childChanged = new EventHandler(childChangeHandler);
                rectangleForm.BackColorChanged += childChanged;
                rectangleForm.Show();
                rectangleFormStack.Push(rectangleForm);
                this.closeRectangularToolStripMenuItem.Enabled = true;
                this.closeAllToolStripMenuItem.Enabled = true;
            }
        }

        private void openCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ellipWidthLocal != 0 && ratioLocal != 0)
            {
                //
                CustomChild customChild = new CustomChild(rectHeightLocal, ratioLocal);
                customChild.MdiParent = this;
                EventHandler childChanged = new EventHandler(childChangeHandler);
                customChild.BackColorChanged += childChanged;
                customChild.Show();
                customChildStack.Push(customChild);
                this.closeCustomToolStripMenuItem.Enabled = true;
                this.closeAllToolStripMenuItem.Enabled = true;
            }
        }

        private void closeEllipticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (ellipseStack.Count > 0)
                ellipseStack.Pop().Close();

            if (EllipsesIsClear())
                this.closeEllipticToolStripMenuItem.Enabled = false;
        }

        private Boolean EllipsesIsClear()
        {
            int count = 0;
            foreach (Ellipse ellipse in ellipseStack)
                if (ellipse.IsDisposed)
                    ++count;

            if (count == ellipseStack.Count) return true;

            return false;
        }

        private Boolean RectanglesIsClear()
        {
            int count = 0;
            foreach (RectangleForm rectangle in rectangleFormStack)
                if (rectangle.IsDisposed)
                    ++count;

            if (count == rectangleFormStack.Count) return true;

            return false;
        }

        private Boolean CustomChildIsClear()
        {
            int count = 0;
            foreach (CustomChild customChild in customChildStack)
                if (customChild.IsDisposed)
                    ++count;

            if (count == customChildStack.Count) return true;

            return false;
        }

        private void closeRectangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (rectangleFormStack.Count > 0)
                rectangleFormStack.Pop().Close();

            if (RectanglesIsClear())
                this.closeRectangularToolStripMenuItem.Enabled = false;
        }


        private void closeCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (customChildStack.Count > 0)
                customChildStack.Pop().Close();

            if (customChildStack.Count == 0)
                this.closeCustomToolStripMenuItem.Enabled = false;
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
            this.closeEllipticToolStripMenuItem.Enabled = false;
            this.closeRectangularToolStripMenuItem.Enabled = false;
            this.closeCustomToolStripMenuItem.Enabled = false;
            this.closeAllToolStripMenuItem.Enabled = false;

            statusLabel.Text = "Ready";
            statusStrip.BackColor = System.Drawing.SystemColors.Control; // reset status strip color after all children close
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        // try to change the reset login dialog menu item to be enabled if the user Skips the Login Dialog
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ShowLogin == true) // if skipping is wanted
                resetLoginScreenToolStripMenuItem.Enabled = true; // enable item if the user skips
            else // if skipping is not wanted  
                resetLoginScreenToolStripMenuItem.Enabled = false; // if login dialog shows then don't enable menu item
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)  // for each child in the container 
            {
                if (ActiveMdiChild is Ellipse)          // if the child is currently active, make status take child info, same for rest below
                {
                    statusLabel.Text = "Ellipse" + ActiveMdiChild.BackColor.ToString();
                    statusStrip.BackColor = ActiveMdiChild.BackColor;
                }
                else if (ActiveMdiChild is RectangleForm)
                {
                    statusLabel.Text = "Rectangle" + ActiveMdiChild.BackColor.ToString();
                    statusStrip.BackColor = ActiveMdiChild.BackColor;
                }
                else if (ActiveMdiChild is CustomChild)
                {
                    statusLabel.Text = "Custom" + ActiveMdiChild.BackColor.ToString();
                    statusStrip.BackColor = ActiveMdiChild.BackColor;
                }
            }
        }

        private void childChangeHandler(object sender, EventArgs e)
        {
            MainForm_MdiChildActivate(sender, e);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RectanglesIsClear())
                this.closeRectangularToolStripMenuItem.Enabled = false;
            if (EllipsesIsClear())
                this.closeEllipticToolStripMenuItem.Enabled = false;
            if (CustomChildIsClear())
                this.closeCustomToolStripMenuItem.Enabled = false;
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oathDialog = new OathDialog();
            oathDialog.Owner = this;        // the main form is the owner of the oath dialog             

            oathDialog.ShowDialog();        // open modally

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
