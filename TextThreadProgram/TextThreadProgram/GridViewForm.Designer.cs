namespace TextThreadProgram
{
    partial class GridViewForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.documentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 366);
            this.dataGridView1.TabIndex = 0;
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
            // GridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GridViewForm";
            this.ShowIcon = false;
            this.Text = "GridViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource documentBindingSource;
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
    }
}