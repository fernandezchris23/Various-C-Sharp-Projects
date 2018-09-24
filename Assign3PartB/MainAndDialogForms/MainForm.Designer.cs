namespace MainAndDialogForms
{
    partial class MainForm
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
            this.preferencesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEllipticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeEllipticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeRectangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModallyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelesslyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesContextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // preferencesContextMenuStrip
            // 
            this.preferencesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.preferencesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem,
            this.openPreferencesModelesslyToolStripMenuItem});
            this.preferencesContextMenuStrip.Name = "preferencesContextMenuStrip";
            this.preferencesContextMenuStrip.Size = new System.Drawing.Size(233, 48);
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openPreferencesModelesslyToolStripMenuItem
            // 
            this.openPreferencesModelesslyToolStripMenuItem.Name = "openPreferencesModelesslyToolStripMenuItem";
            this.openPreferencesModelesslyToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.openPreferencesModelesslyToolStripMenuItem.Text = "Open Preferences Modelessly ";
            this.openPreferencesModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelesslyToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(600, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEllipticToolStripMenuItem,
            this.openRectangularToolStripMenuItem,
            this.closeEllipticToolStripMenuItem,
            this.closeRectangularToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openEllipticToolStripMenuItem
            // 
            this.openEllipticToolStripMenuItem.Name = "openEllipticToolStripMenuItem";
            this.openEllipticToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openEllipticToolStripMenuItem.Text = "Open Elliptic";
            this.openEllipticToolStripMenuItem.Click += new System.EventHandler(this.openEllipticToolStripMenuItem_Click);
            // 
            // openRectangularToolStripMenuItem
            // 
            this.openRectangularToolStripMenuItem.Name = "openRectangularToolStripMenuItem";
            this.openRectangularToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openRectangularToolStripMenuItem.Text = "Open Rectangular";
            this.openRectangularToolStripMenuItem.Click += new System.EventHandler(this.openRectangularToolStripMenuItem_Click);
            // 
            // closeEllipticToolStripMenuItem
            // 
            this.closeEllipticToolStripMenuItem.Name = "closeEllipticToolStripMenuItem";
            this.closeEllipticToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.closeEllipticToolStripMenuItem.Text = "Close Elliptic";
            this.closeEllipticToolStripMenuItem.Click += new System.EventHandler(this.closeEllipticToolStripMenuItem_Click);
            // 
            // closeRectangularToolStripMenuItem
            // 
            this.closeRectangularToolStripMenuItem.Name = "closeRectangularToolStripMenuItem";
            this.closeRectangularToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.closeRectangularToolStripMenuItem.Text = "Close Rectangular";
            this.closeRectangularToolStripMenuItem.Click += new System.EventHandler(this.closeRectangularToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem1,
            this.openPreferencesModelesslyToolStripMenuItem1});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // openPreferencesModallyToolStripMenuItem1
            // 
            this.openPreferencesModallyToolStripMenuItem1.Name = "openPreferencesModallyToolStripMenuItem1";
            this.openPreferencesModallyToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.openPreferencesModallyToolStripMenuItem1.Text = "Open Preferences Modally ";
            this.openPreferencesModallyToolStripMenuItem1.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openPreferencesModelesslyToolStripMenuItem1
            // 
            this.openPreferencesModelesslyToolStripMenuItem1.Name = "openPreferencesModelesslyToolStripMenuItem1";
            this.openPreferencesModelesslyToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.openPreferencesModelesslyToolStripMenuItem1.Text = "Open Preferences Modelessly ";
            this.openPreferencesModelesslyToolStripMenuItem1.Click += new System.EventHandler(this.openPreferencesModelesslyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ContextMenuStrip = this.preferencesContextMenuStrip;
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.preferencesContextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip preferencesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModelesslyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEllipticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRectangularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeEllipticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeRectangularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModelesslyToolStripMenuItem1;
    }
}