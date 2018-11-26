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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
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
            this.addFavBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.linkHoveringOvertoolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            // 
            // addrBarText
            // 
            this.addrBarText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addrBarText.Location = new System.Drawing.Point(101, 11);
            this.addrBarText.Name = "addrBarText";
            this.addrBarText.Size = new System.Drawing.Size(664, 20);
            this.addrBarText.TabIndex = 3;
            this.addrBarText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addrBarText_KeyDown);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(65, 6);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(30, 30);
            this.homeButton.TabIndex = 2;
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.Location = new System.Drawing.Point(35, 9);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(25, 25);
            this.forwardButton.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(3, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(25, 25);
            this.backButton.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 66);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(800, 360);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkHoveringOvertoolStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
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
            this.printToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuButton.Name = "contextMenuButton";
            this.contextMenuButton.Size = new System.Drawing.Size(146, 170);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.helpToolStripMenuItem.Text = "Help";
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
            this.favToolStrip.Size = new System.Drawing.Size(797, 25);
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
            this.addFavBttn.Size = new System.Drawing.Size(23, 22);
            this.addFavBttn.Text = "Add Favorite";
            this.addFavBttn.Click += new System.EventHandler(this.addFavBttn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(287, 438);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // linkHoveringOvertoolStripLabel
            // 
            this.linkHoveringOvertoolStripLabel.Name = "linkHoveringOvertoolStripLabel";
            this.linkHoveringOvertoolStripLabel.Size = new System.Drawing.Size(10, 17);
            this.linkHoveringOvertoolStripLabel.Text = " ";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.favToolStrip);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.addrBar);
            this.Name = "Browser";
            this.Text = "Form1";
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
    }
}

