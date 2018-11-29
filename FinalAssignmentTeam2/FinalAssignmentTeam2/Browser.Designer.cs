namespace FinalAssignmentTeam2
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.addrBar = new System.Windows.Forms.GroupBox();
            this.menuButton = new ControlLibrary.MenuButton();
            this.addrBarText = new System.Windows.Forms.TextBox();
            this.homeButton = new ControlLibrary.HomeButton();
            this.forwardButton = new ControlLibrary.ForwardButton();
            this.backButton = new ControlLibrary.BackButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.linkHoveringOvertoolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favToolStrip = new System.Windows.Forms.ToolStrip();
            this.addFavBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusFactButton = new System.Windows.Forms.ToolStripSplitButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyTimer = new System.Windows.Forms.Timer(this.components);
            this.addrBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuButton.SuspendLayout();
            this.favToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addrBar
            // 
            this.addrBar.Controls.Add(this.menuButton);
            this.addrBar.Controls.Add(this.addrBarText);
            this.addrBar.Controls.Add(this.homeButton);
            this.addrBar.Controls.Add(this.forwardButton);
            this.addrBar.Controls.Add(this.backButton);
            this.addrBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.addrBar.Location = new System.Drawing.Point(0, 0);
            this.addrBar.Name = "addrBar";
            this.addrBar.Size = new System.Drawing.Size(800, 38);
            this.addrBar.TabIndex = 1;
            this.addrBar.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Location = new System.Drawing.Point(771, 9);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(25, 25);
            this.menuButton.TabIndex = 4;
            this.toolTip.SetToolTip(this.menuButton, "Menu");
            // 
            // addrBarText
            // 
            this.addrBarText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addrBarText.Location = new System.Drawing.Point(101, 11);
            this.addrBarText.Name = "addrBarText";
            this.addrBarText.Size = new System.Drawing.Size(664, 20);
            this.addrBarText.TabIndex = 3;
            this.toolTip.SetToolTip(this.addrBarText, "Enter URL...");
            this.addrBarText.Click += new System.EventHandler(this.addrBarText_Click);
            this.addrBarText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addrBarText_KeyDown);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(65, 6);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(30, 30);
            this.homeButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.homeButton, "Home");
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.Location = new System.Drawing.Point(35, 9);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(25, 25);
            this.forwardButton.TabIndex = 1;
            this.toolTip.SetToolTip(this.forwardButton, "Forward");
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(3, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(25, 25);
            this.backButton.TabIndex = 0;
            this.toolTip.SetToolTip(this.backButton, "Back");
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkHoveringOvertoolStripLabel,
            this.toolStripStatusFactButton});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // linkHoveringOvertoolStripLabel
            // 
            this.linkHoveringOvertoolStripLabel.Name = "linkHoveringOvertoolStripLabel";
            this.linkHoveringOvertoolStripLabel.Size = new System.Drawing.Size(749, 17);
            this.linkHoveringOvertoolStripLabel.Spring = true;
            this.linkHoveringOvertoolStripLabel.Text = " ";
            // 
            // contextMenuButton
            // 
            this.contextMenuButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.toolStripSeparator1,
            this.historyToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.helpToolStripMenuItem,
            this.closeTabToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuButton.Name = "contextMenuButton";
            this.contextMenuButton.Size = new System.Drawing.Size(146, 242);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripLabel_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(142, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // favToolStrip
            // 
            this.favToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favToolStrip.AutoSize = false;
            this.favToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.favToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFavBttn,
            this.toolStripSeparator3});
            this.favToolStrip.Location = new System.Drawing.Point(3, 37);
            this.favToolStrip.Name = "favToolStrip";
            this.favToolStrip.Size = new System.Drawing.Size(797, 27);
            this.favToolStrip.Stretch = true;
            this.favToolStrip.TabIndex = 5;
            this.favToolStrip.Text = "toolStrip1";
            // 
            // addFavBttn
            // 
            this.addFavBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addFavBttn.Image = ((System.Drawing.Image)(resources.GetObject("addFavBttn.Image")));
            this.addFavBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFavBttn.Name = "addFavBttn";
            this.addFavBttn.Size = new System.Drawing.Size(23, 24);
            this.addFavBttn.Text = "Add Favorite";
            this.addFavBttn.Click += new System.EventHandler(this.addFavBttn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(287, 438);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(0, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 359);
            this.tabControl.TabIndex = 7;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // toolStripStatusFactButton
            // 
            this.toolStripStatusFactButton.AutoSize = false;
            this.toolStripStatusFactButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusFactButton.Enabled = false;
            this.toolStripStatusFactButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusFactButton.Image")));
            this.toolStripStatusFactButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStatusFactButton.Name = "toolStripStatusFactButton";
            this.toolStripStatusFactButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusFactButton.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusFactButton.Text = "Cat Facts";
            this.toolStripStatusFactButton.ToolTipText = "Cat Facts";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Browsing Kitty";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyTimer
            // 
            this.notifyTimer.Tick += new System.EventHandler(this.notifyTimer_Tick);
            // 
            // Browser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.favToolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.addrBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Browser_FormClosing);
            this.Load += new System.EventHandler(this.Browser_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Browser_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Browser_DragEnter);
            this.addrBar.ResumeLayout(false);
            this.addrBar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuButton.ResumeLayout(false);
            this.favToolStrip.ResumeLayout(false);
            this.favToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addrBar;
        private ControlLibrary.MenuButton menuButton;
        private System.Windows.Forms.TextBox addrBarText;
        private ControlLibrary.HomeButton homeButton;
        private ControlLibrary.ForwardButton forwardButton;
        private ControlLibrary.BackButton backButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuButton;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip favToolStrip;
        private System.Windows.Forms.ToolStripButton addFavBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripStatusLabel linkHoveringOvertoolStripLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSplitButton toolStripStatusFactButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer notifyTimer;
    }
}

