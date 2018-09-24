namespace ControlLibraryAssign3
{
    partial class BaseForm
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
            this.baseFormsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseFormColorDialog = new System.Windows.Forms.ColorDialog();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.baseFormsContextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseFormsContextMenuStrip
            // 
            this.baseFormsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseFormsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.baseFormsContextMenuStrip.Name = "baseFormsContextMenuStrip";
            this.baseFormsContextMenuStrip.Size = new System.Drawing.Size(136, 48);
            this.baseFormsContextMenuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeChildToolStripMenuItem});
            this.fileMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            this.fileMenuItem.Visible = false;
            // 
            // closeChildToolStripMenuItem
            // 
            this.closeChildToolStripMenuItem.Name = "closeChildToolStripMenuItem";
            this.closeChildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeChildToolStripMenuItem.Text = "Close Child";
            this.closeChildToolStripMenuItem.Click += new System.EventHandler(this.closeChildToolStripMenuItem_Click);
            // 
            // prefMenuItem
            // 
            this.prefMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem1});
            this.prefMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.prefMenuItem.Name = "prefMenuItem";
            this.prefMenuItem.Size = new System.Drawing.Size(80, 20);
            this.prefMenuItem.Text = "Preferences";
            this.prefMenuItem.Visible = false;
            // 
            // colorsToolStripMenuItem1
            // 
            this.colorsToolStripMenuItem1.Name = "colorsToolStripMenuItem1";
            this.colorsToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.colorsToolStripMenuItem1.Text = "Colors";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.prefMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(600, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ContextMenuStrip = this.baseFormsContextMenuStrip;
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Base_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Base_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Base_MouseUp);
            this.baseFormsContextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip baseFormsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog baseFormColorDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}