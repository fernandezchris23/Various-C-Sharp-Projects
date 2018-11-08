namespace TextThreadProgram
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsCtrlShiftSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.capsLockStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.drawTabControl = new System.Windows.Forms.TabControl();
            this.drawTabPage = new System.Windows.Forms.TabPage();
            this.gridviewTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.stringTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textLocationXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textLocationYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textFontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.drawTabControl.SuspendLayout();
            this.drawTabPage.SuspendLayout();
            this.gridviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.gridViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openCtrlToolStripMenuItem,
            this.importTextFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsCtrlShiftSToolStripMenuItem,
            this.closeAltF4ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openCtrlToolStripMenuItem
            // 
            this.openCtrlToolStripMenuItem.Name = "openCtrlToolStripMenuItem";
            this.openCtrlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openCtrlToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.openCtrlToolStripMenuItem.Text = "Open";
            this.openCtrlToolStripMenuItem.Click += new System.EventHandler(this.openCtrlToolStripMenuItem_Click);
            // 
            // importTextFileToolStripMenuItem
            // 
            this.importTextFileToolStripMenuItem.Name = "importTextFileToolStripMenuItem";
            this.importTextFileToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.importTextFileToolStripMenuItem.Text = "Import Text File";
            this.importTextFileToolStripMenuItem.Click += new System.EventHandler(this.importTextFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsCtrlShiftSToolStripMenuItem
            // 
            this.saveAsCtrlShiftSToolStripMenuItem.Name = "saveAsCtrlShiftSToolStripMenuItem";
            this.saveAsCtrlShiftSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsCtrlShiftSToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.saveAsCtrlShiftSToolStripMenuItem.Text = "Save As";
            this.saveAsCtrlShiftSToolStripMenuItem.Click += new System.EventHandler(this.saveAsCtrlShiftSToolStripMenuItem_Click);
            // 
            // closeAltF4ToolStripMenuItem
            // 
            this.closeAltF4ToolStripMenuItem.Name = "closeAltF4ToolStripMenuItem";
            this.closeAltF4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeAltF4ToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.closeAltF4ToolStripMenuItem.Text = "Close";
            this.closeAltF4ToolStripMenuItem.Click += new System.EventHandler(this.closeAltF4ToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutCtrlXToolStripMenuItem,
            this.copyCtrlCToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutCtrlXToolStripMenuItem
            // 
            this.cutCtrlXToolStripMenuItem.Name = "cutCtrlXToolStripMenuItem";
            this.cutCtrlXToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.cutCtrlXToolStripMenuItem.Text = "Cut (Ctrl+X)";
            this.cutCtrlXToolStripMenuItem.Click += new System.EventHandler(this.cutCtrlXToolStripMenuItem_Click);
            // 
            // copyCtrlCToolStripMenuItem
            // 
            this.copyCtrlCToolStripMenuItem.Name = "copyCtrlCToolStripMenuItem";
            this.copyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.copyCtrlCToolStripMenuItem.Text = "Copy (Ctrl+C)";
            this.copyCtrlCToolStripMenuItem.Click += new System.EventHandler(this.copyCtrlCToolStripMenuItem_Click);
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            this.pasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.pasteCtrlVToolStripMenuItem.Text = "Paste (Ctrl+V)";
            this.pasteCtrlVToolStripMenuItem.Click += new System.EventHandler(this.pasteCtrlVToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gridViewToolStripMenuItem
            // 
            this.gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            this.gridViewToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.gridViewToolStripMenuItem.Text = "GridView";
            this.gridViewToolStripMenuItem.Click += new System.EventHandler(this.gridViewToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capsLockStatusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // capsLockStatusStrip
            // 
            this.capsLockStatusStrip.Name = "capsLockStatusStrip";
            this.capsLockStatusStrip.Size = new System.Drawing.Size(111, 20);
            this.capsLockStatusStrip.Text = "CapsLockStatus";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gray;
            this.mainPanel.Location = new System.Drawing.Point(6, 5);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(756, 352);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainPanel_DragDrop);
            this.mainPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainPanel_DragEnter);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseClick);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // drawTabControl
            // 
            this.drawTabControl.Controls.Add(this.drawTabPage);
            this.drawTabControl.Controls.Add(this.gridviewTabPage);
            this.drawTabControl.Location = new System.Drawing.Point(12, 31);
            this.drawTabControl.Name = "drawTabControl";
            this.drawTabControl.SelectedIndex = 0;
            this.drawTabControl.Size = new System.Drawing.Size(776, 391);
            this.drawTabControl.TabIndex = 3;
            this.drawTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.drawTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            // 
            // drawTabPage
            // 
            this.drawTabPage.Controls.Add(this.mainPanel);
            this.drawTabPage.Location = new System.Drawing.Point(4, 25);
            this.drawTabPage.Name = "drawTabPage";
            this.drawTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.drawTabPage.Size = new System.Drawing.Size(768, 362);
            this.drawTabPage.TabIndex = 0;
            this.drawTabPage.Text = "Draw";
            this.drawTabPage.UseVisualStyleBackColor = true;
            // 
            // gridviewTabPage
            // 
            this.gridviewTabPage.Controls.Add(this.removeBtn);
            this.gridviewTabPage.Controls.Add(this.dataGridView);
            this.gridviewTabPage.Location = new System.Drawing.Point(4, 25);
            this.gridviewTabPage.Name = "gridviewTabPage";
            this.gridviewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gridviewTabPage.Size = new System.Drawing.Size(768, 362);
            this.gridviewTabPage.TabIndex = 1;
            this.gridviewTabPage.Text = "Gridview";
            this.gridviewTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stringTextDataGridViewTextBoxColumn,
            this.zOrderDataGridViewTextBoxColumn,
            this.rotationDataGridViewTextBoxColumn,
            this.textColorDataGridViewTextBoxColumn,
            this.bgColorDataGridViewTextBoxColumn,
            this.textLocationXDataGridViewTextBoxColumn,
            this.textLocationYDataGridViewTextBoxColumn,
            this.textLocationDataGridViewTextBoxColumn,
            this.textFontDataGridViewTextBoxColumn,
            this.textSizeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.documentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(6, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(756, 304);
            this.dataGridView.TabIndex = 0;
            // 
            // stringTextDataGridViewTextBoxColumn
            // 
            this.stringTextDataGridViewTextBoxColumn.DataPropertyName = "StringText";
            this.stringTextDataGridViewTextBoxColumn.HeaderText = "StringText";
            this.stringTextDataGridViewTextBoxColumn.Name = "stringTextDataGridViewTextBoxColumn";
            // 
            // zOrderDataGridViewTextBoxColumn
            // 
            this.zOrderDataGridViewTextBoxColumn.DataPropertyName = "Z_Order";
            this.zOrderDataGridViewTextBoxColumn.HeaderText = "Z_Order";
            this.zOrderDataGridViewTextBoxColumn.Name = "zOrderDataGridViewTextBoxColumn";
            // 
            // rotationDataGridViewTextBoxColumn
            // 
            this.rotationDataGridViewTextBoxColumn.DataPropertyName = "Rotation";
            this.rotationDataGridViewTextBoxColumn.HeaderText = "Rotation";
            this.rotationDataGridViewTextBoxColumn.Name = "rotationDataGridViewTextBoxColumn";
            // 
            // textColorDataGridViewTextBoxColumn
            // 
            this.textColorDataGridViewTextBoxColumn.DataPropertyName = "TextColor";
            this.textColorDataGridViewTextBoxColumn.HeaderText = "TextColor";
            this.textColorDataGridViewTextBoxColumn.Name = "textColorDataGridViewTextBoxColumn";
            // 
            // bgColorDataGridViewTextBoxColumn
            // 
            this.bgColorDataGridViewTextBoxColumn.DataPropertyName = "BgColor";
            this.bgColorDataGridViewTextBoxColumn.HeaderText = "BgColor";
            this.bgColorDataGridViewTextBoxColumn.Name = "bgColorDataGridViewTextBoxColumn";
            // 
            // textLocationXDataGridViewTextBoxColumn
            // 
            this.textLocationXDataGridViewTextBoxColumn.DataPropertyName = "TextLocationX";
            this.textLocationXDataGridViewTextBoxColumn.HeaderText = "TextLocationX";
            this.textLocationXDataGridViewTextBoxColumn.Name = "textLocationXDataGridViewTextBoxColumn";
            // 
            // textLocationYDataGridViewTextBoxColumn
            // 
            this.textLocationYDataGridViewTextBoxColumn.DataPropertyName = "TextLocationY";
            this.textLocationYDataGridViewTextBoxColumn.HeaderText = "TextLocationY";
            this.textLocationYDataGridViewTextBoxColumn.Name = "textLocationYDataGridViewTextBoxColumn";
            // 
            // textLocationDataGridViewTextBoxColumn
            // 
            this.textLocationDataGridViewTextBoxColumn.DataPropertyName = "TextLocation";
            this.textLocationDataGridViewTextBoxColumn.HeaderText = "TextLocation";
            this.textLocationDataGridViewTextBoxColumn.Name = "textLocationDataGridViewTextBoxColumn";
            // 
            // textFontDataGridViewTextBoxColumn
            // 
            this.textFontDataGridViewTextBoxColumn.DataPropertyName = "TextFont";
            this.textFontDataGridViewTextBoxColumn.HeaderText = "TextFont";
            this.textFontDataGridViewTextBoxColumn.Name = "textFontDataGridViewTextBoxColumn";
            // 
            // textSizeDataGridViewTextBoxColumn
            // 
            this.textSizeDataGridViewTextBoxColumn.DataPropertyName = "TextSize";
            this.textSizeDataGridViewTextBoxColumn.HeaderText = "TextSize";
            this.textSizeDataGridViewTextBoxColumn.Name = "textSizeDataGridViewTextBoxColumn";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(TextThreadProgram.Document);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(6, 333);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.drawTabControl.ResumeLayout(false);
            this.drawTabPage.ResumeLayout(false);
            this.gridviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsCtrlShiftSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel capsLockStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridViewToolStripMenuItem;
        private System.Windows.Forms.TabControl drawTabControl;
        private System.Windows.Forms.TabPage drawTabPage;
        private System.Windows.Forms.TabPage gridviewTabPage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stringTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textLocationXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textLocationYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textFontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.Button removeBtn;
    }
}

