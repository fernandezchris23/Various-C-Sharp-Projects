﻿namespace MainAndDialogForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.preferencesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEllipticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeEllipticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeRectangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModallyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelesslyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLoginScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesContextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // preferencesContextMenuStrip
            // 
            this.preferencesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.preferencesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem,
            this.openPreferencesModelesslyToolStripMenuItem});
            this.preferencesContextMenuStrip.Name = "preferencesContextMenuStrip";
            this.preferencesContextMenuStrip.Size = new System.Drawing.Size(277, 52);
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openPreferencesModelesslyToolStripMenuItem
            // 
            this.openPreferencesModelesslyToolStripMenuItem.Name = "openPreferencesModelesslyToolStripMenuItem";
            this.openPreferencesModelesslyToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.openPreferencesModelesslyToolStripMenuItem.Text = "Open Preferences Modelessly ";
            this.openPreferencesModelesslyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelesslyToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEllipticToolStripMenuItem,
            this.openRectangularToolStripMenuItem,
            this.openCustomToolStripMenuItem,
            this.closeEllipticToolStripMenuItem,
            this.closeRectangularToolStripMenuItem,
            this.closeCustomToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openEllipticToolStripMenuItem
            // 
            this.openEllipticToolStripMenuItem.Name = "openEllipticToolStripMenuItem";
            this.openEllipticToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.openEllipticToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.openEllipticToolStripMenuItem.Text = "Open Elliptic";
            this.openEllipticToolStripMenuItem.Click += new System.EventHandler(this.openEllipticToolStripMenuItem_Click);
            // 
            // openRectangularToolStripMenuItem
            // 
            this.openRectangularToolStripMenuItem.Name = "openRectangularToolStripMenuItem";
            this.openRectangularToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.openRectangularToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.openRectangularToolStripMenuItem.Text = "Open Rectangular";
            this.openRectangularToolStripMenuItem.Click += new System.EventHandler(this.openRectangularToolStripMenuItem_Click);
            // 
            // openCustomToolStripMenuItem
            // 
            this.openCustomToolStripMenuItem.Name = "openCustomToolStripMenuItem";
            this.openCustomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.openCustomToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.openCustomToolStripMenuItem.Text = "Open Custom";
            this.openCustomToolStripMenuItem.Click += new System.EventHandler(this.openCustomToolStripMenuItem_Click);
            // 
            // closeEllipticToolStripMenuItem
            // 
            this.closeEllipticToolStripMenuItem.Name = "closeEllipticToolStripMenuItem";
            this.closeEllipticToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.closeEllipticToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.closeEllipticToolStripMenuItem.Text = "Close Elliptic";
            this.closeEllipticToolStripMenuItem.Click += new System.EventHandler(this.closeEllipticToolStripMenuItem_Click);
            // 
            // closeRectangularToolStripMenuItem
            // 
            this.closeRectangularToolStripMenuItem.Name = "closeRectangularToolStripMenuItem";
            this.closeRectangularToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.closeRectangularToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.closeRectangularToolStripMenuItem.Text = "Close Rectangular";
            this.closeRectangularToolStripMenuItem.Click += new System.EventHandler(this.closeRectangularToolStripMenuItem_Click);
            // 
            // closeCustomToolStripMenuItem
            // 
            this.closeCustomToolStripMenuItem.Name = "closeCustomToolStripMenuItem";
            this.closeCustomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.closeCustomToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.closeCustomToolStripMenuItem.Text = "Close Custom";
            this.closeCustomToolStripMenuItem.Click += new System.EventHandler(this.closeCustomToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem1,
            this.openPreferencesModelesslyToolStripMenuItem1,
            this.resetLoginScreenToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // openPreferencesModallyToolStripMenuItem1
            // 
            this.openPreferencesModallyToolStripMenuItem1.Name = "openPreferencesModallyToolStripMenuItem1";
            this.openPreferencesModallyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openPreferencesModallyToolStripMenuItem1.Size = new System.Drawing.Size(375, 26);
            this.openPreferencesModallyToolStripMenuItem1.Text = "Open Preferences Modally ";
            this.openPreferencesModallyToolStripMenuItem1.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openPreferencesModelesslyToolStripMenuItem1
            // 
            this.openPreferencesModelesslyToolStripMenuItem1.Name = "openPreferencesModelesslyToolStripMenuItem1";
            this.openPreferencesModelesslyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openPreferencesModelesslyToolStripMenuItem1.Size = new System.Drawing.Size(375, 26);
            this.openPreferencesModelesslyToolStripMenuItem1.Text = "Open Preferences Modelessly ";
            this.openPreferencesModelesslyToolStripMenuItem1.Click += new System.EventHandler(this.openPreferencesModelesslyToolStripMenuItem_Click);
            // 
            // resetLoginScreenToolStripMenuItem
            // 
            this.resetLoginScreenToolStripMenuItem.Name = "resetLoginScreenToolStripMenuItem";
            this.resetLoginScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.resetLoginScreenToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.resetLoginScreenToolStripMenuItem.Text = "Reset Login Screen";
            this.resetLoginScreenToolStripMenuItem.Click += new System.EventHandler(this.resetLoginScreenToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 425);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(800, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 20);
            this.statusLabel.Text = "Ready";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.preferencesContextMenuStrip;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.preferencesContextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem openCustomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCustomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLoginScreenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}