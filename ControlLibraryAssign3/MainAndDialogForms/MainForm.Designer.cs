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
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRectanglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEllipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenu
            // 
            this.ContextMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalToolStripMenuItem,
            this.modelessToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.OwnerItem = this.preferencesToolStripMenuItem;
            this.ContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // modalToolStripMenuItem
            // 
            this.modalToolStripMenuItem.Name = "modalToolStripMenuItem";
            this.modalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modalToolStripMenuItem.Text = "Modal Dialog";
            this.modalToolStripMenuItem.Click += new System.EventHandler(this.modalToolStripMenuItem_Click);
            // 
            // modelessToolStripMenuItem
            // 
            this.modelessToolStripMenuItem.Name = "modelessToolStripMenuItem";
            this.modelessToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modelessToolStripMenuItem.Text = "Modeless Dialog";
            this.modalToolStripMenuItem.Click += new System.EventHandler(this.modelessToolStripMenuItem_Click);

            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDown = this.ContextMenu;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openChildToolStripMenuItem,
            this.closeChildToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openChildToolStripMenuItem
            // 
            this.openChildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseToolStripMenuItem,
            this.rectangleToolStripMenuItem});
            this.openChildToolStripMenuItem.Name = "openChildToolStripMenuItem";
            this.openChildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openChildToolStripMenuItem.Text = "Open Child";
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // closeChildToolStripMenuItem
            // 
            this.closeChildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allRectanglesToolStripMenuItem,
            this.allEllipsesToolStripMenuItem});
            this.closeChildToolStripMenuItem.Name = "closeChildToolStripMenuItem";
            this.closeChildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeChildToolStripMenuItem.Text = "Close Child";
            // 
            // allRectanglesToolStripMenuItem
            // 
            this.allRectanglesToolStripMenuItem.Name = "allRectanglesToolStripMenuItem";
            this.allRectanglesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allRectanglesToolStripMenuItem.Text = "All Rectangles";
            this.allRectanglesToolStripMenuItem.Click += new System.EventHandler(this.allRectanglesToolStripMenuItem_Click);
            // 
            // allEllipsesToolStripMenuItem
            // 
            this.allEllipsesToolStripMenuItem.Name = "allEllipsesToolStripMenuItem";
            this.allEllipsesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allEllipsesToolStripMenuItem.Text = "All Ellipses";
            this.allEllipsesToolStripMenuItem.Click += new System.EventHandler(this.allEllipsesToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ContextMenu.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRectanglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEllipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelessToolStripMenuItem;
    }
}