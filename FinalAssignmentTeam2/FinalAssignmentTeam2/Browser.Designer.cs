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
            this.addrBarText = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.linkHoveringOvertoolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuButton = new ControlLibrary.MenuButton();
            this.homeButton = new ControlLibrary.HomeButton();
            this.forwardButton = new ControlLibrary.ForwardButton();
            this.backButton = new ControlLibrary.BackButton();
            this.addFavBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusFactButton = new System.Windows.Forms.ToolStripSplitButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
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
            this.addrBar.Margin = new System.Windows.Forms.Padding(4);
            this.addrBar.Name = "addrBar";
            this.addrBar.Padding = new System.Windows.Forms.Padding(4);
            this.addrBar.Size = new System.Drawing.Size(1067, 47);
            this.addrBar.TabIndex = 1;
            this.addrBar.TabStop = false;
            // 
            // addrBarText
            // 
            this.addrBarText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addrBarText.Location = new System.Drawing.Point(135, 14);
            this.addrBarText.Margin = new System.Windows.Forms.Padding(4);
            this.addrBarText.Name = "addrBarText";
            this.addrBarText.Size = new System.Drawing.Size(884, 22);
            this.addrBarText.TabIndex = 3;
            this.addrBarText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addrBarText_KeyDown);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 81);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1067, 531);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkHoveringOvertoolStripLabel,
            this.toolStripStatusFactButton});
            this.statusStrip.Location = new System.Drawing.Point(0, 616);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // linkHoveringOvertoolStripLabel
            // 
            this.linkHoveringOvertoolStripLabel.Name = "linkHoveringOvertoolStripLabel";
            this.linkHoveringOvertoolStripLabel.Size = new System.Drawing.Size(1008, 21);
            this.linkHoveringOvertoolStripLabel.Spring = true;
            this.linkHoveringOvertoolStripLabel.Text = " ";
            // 
            // contextMenuButton
            // 
            this.contextMenuButton.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.toolStripSeparator1,
            this.historyToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuButton.Name = "contextMenuButton";
            this.contextMenuButton.Size = new System.Drawing.Size(168, 184);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.newTabToolStripMenuItem.Text = "New Tab";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // favToolStrip
            // 
            this.favToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favToolStrip.AutoSize = false;
            this.favToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.favToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.favToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFavBttn,
            this.toolStripSeparator3});
            this.favToolStrip.Location = new System.Drawing.Point(4, 46);
            this.favToolStrip.Name = "favToolStrip";
            this.favToolStrip.Size = new System.Drawing.Size(1063, 31);
            this.favToolStrip.Stretch = true;
            this.favToolStrip.TabIndex = 5;
            this.favToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(397, 399);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Location = new System.Drawing.Point(1028, 11);
            this.menuButton.Margin = new System.Windows.Forms.Padding(5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(33, 31);
            this.menuButton.TabIndex = 4;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(87, 7);
            this.homeButton.Margin = new System.Windows.Forms.Padding(5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(40, 37);
            this.homeButton.TabIndex = 2;
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.Location = new System.Drawing.Point(47, 11);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(5);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(33, 31);
            this.forwardButton.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(4, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(33, 31);
            this.backButton.TabIndex = 0;
            // 
            // addFavBttn
            // 
            this.addFavBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addFavBttn.Image = global::FinalAssignmentTeam2.Properties.Resources.redHeartCatPaw;
            this.addFavBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFavBttn.Name = "addFavBttn";
            this.addFavBttn.Size = new System.Drawing.Size(24, 28);
            this.addFavBttn.Text = "Add Favorite";
            this.addFavBttn.Click += new System.EventHandler(this.addFavBttn_Click);
            // 
            // toolStripStatusFactButton
            // 
            this.toolStripStatusFactButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusFactButton.Enabled = false;
            this.toolStripStatusFactButton.Image = global::FinalAssignmentTeam2.Properties.Resources.kitty;
            this.toolStripStatusFactButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStatusFactButton.Name = "toolStripStatusFactButton";
            this.toolStripStatusFactButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusFactButton.Size = new System.Drawing.Size(39, 24);
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
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 642);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.favToolStrip);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.addrBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Browser";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Browser_Load);
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
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuButton;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip favToolStrip;
        private System.Windows.Forms.ToolStripButton addFavBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripStatusLabel linkHoveringOvertoolStripLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSplitButton toolStripStatusFactButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

