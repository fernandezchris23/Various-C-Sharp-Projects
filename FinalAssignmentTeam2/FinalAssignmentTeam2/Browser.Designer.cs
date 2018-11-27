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
            this.webBrowserTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newTabToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.addrBar.SuspendLayout();
            this.contextMenuButton.SuspendLayout();
            this.favToolStrip.SuspendLayout();
            this.webBrowserTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.addrBar.Size = new System.Drawing.Size(1337, 47);
            this.addrBar.TabIndex = 1;
            this.addrBar.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Location = new System.Drawing.Point(1298, 11);
            this.menuButton.Margin = new System.Windows.Forms.Padding(5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(33, 31);
            this.menuButton.TabIndex = 4;
            // 
            // addrBarText
            // 
            this.addrBarText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addrBarText.Location = new System.Drawing.Point(135, 14);
            this.addrBarText.Margin = new System.Windows.Forms.Padding(4);
            this.addrBarText.Name = "addrBarText";
            this.addrBarText.Size = new System.Drawing.Size(1154, 22);
            this.addrBarText.TabIndex = 3;
            this.addrBarText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addrBarText_KeyDown);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(87, 11);
            this.homeButton.Margin = new System.Windows.Forms.Padding(5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(39, 31);
            this.homeButton.TabIndex = 2;
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.Location = new System.Drawing.Point(52, 11);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(5);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(33, 31);
            this.forwardButton.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(9, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(33, 31);
            this.backButton.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 4);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1325, 546);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 664);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1337, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
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
            this.favToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.favToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.favToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.favToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFavBttn,
            this.toolStripSeparator3,
            this.newTabToolStripLabel});
            this.favToolStrip.Location = new System.Drawing.Point(4, 51);
            this.favToolStrip.Name = "favToolStrip";
            this.favToolStrip.Size = new System.Drawing.Size(1333, 31);
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
            this.addFavBttn.Size = new System.Drawing.Size(24, 28);
            this.addFavBttn.Text = "Add Favorite";
            this.addFavBttn.Click += new System.EventHandler(this.addFavBttn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // webBrowserTabControl
            // 
            this.webBrowserTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserTabControl.Controls.Add(this.tabPage2);
            this.webBrowserTabControl.Location = new System.Drawing.Point(0, 85);
            this.webBrowserTabControl.Name = "webBrowserTabControl";
            this.webBrowserTabControl.SelectedIndex = 0;
            this.webBrowserTabControl.Size = new System.Drawing.Size(1337, 579);
            this.webBrowserTabControl.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1329, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // newTabToolStripLabel
            // 
            this.newTabToolStripLabel.Name = "newTabToolStripLabel";
            this.newTabToolStripLabel.Size = new System.Drawing.Size(66, 28);
            this.newTabToolStripLabel.Text = "New Tab";
            this.newTabToolStripLabel.Click += new System.EventHandler(this.newTabToolStripLabel_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 686);
            this.Controls.Add(this.webBrowserTabControl);
            this.Controls.Add(this.favToolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.addrBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Browser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.addrBar.ResumeLayout(false);
            this.addrBar.PerformLayout();
            this.contextMenuButton.ResumeLayout(false);
            this.favToolStrip.ResumeLayout(false);
            this.favToolStrip.PerformLayout();
            this.webBrowserTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl webBrowserTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripLabel newTabToolStripLabel;
    }
}

