namespace FinalAssignmentTeam2
{
    partial class History
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
            this.listOfItems = new System.Windows.Forms.ListBox();
            this.histLabel = new System.Windows.Forms.Label();
            this.clearHistoryBttn = new System.Windows.Forms.Button();
            this.clearDayBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfItems
            // 
            this.listOfItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfItems.FormattingEnabled = true;
            this.listOfItems.ItemHeight = 16;
            this.listOfItems.Location = new System.Drawing.Point(232, 53);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.Size = new System.Drawing.Size(368, 468);
            this.listOfItems.TabIndex = 0;
            this.listOfItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOfItems_MouseDoubleClick);
            // 
            // histLabel
            // 
            this.histLabel.AutoSize = true;
            this.histLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histLabel.Location = new System.Drawing.Point(32, 25);
            this.histLabel.Name = "histLabel";
            this.histLabel.Size = new System.Drawing.Size(102, 32);
            this.histLabel.TabIndex = 1;
            this.histLabel.Text = "History";
            // 
            // clearHistoryBttn
            // 
            this.clearHistoryBttn.Location = new System.Drawing.Point(37, 91);
            this.clearHistoryBttn.Name = "clearHistoryBttn";
            this.clearHistoryBttn.Size = new System.Drawing.Size(115, 23);
            this.clearHistoryBttn.TabIndex = 2;
            this.clearHistoryBttn.Text = "Clear History";
            this.clearHistoryBttn.UseVisualStyleBackColor = true;
            this.clearHistoryBttn.Click += new System.EventHandler(this.clearHistoryBttn_Click);
            // 
            // clearDayBttn
            // 
            this.clearDayBttn.Location = new System.Drawing.Point(38, 137);
            this.clearDayBttn.Name = "clearDayBttn";
            this.clearDayBttn.Size = new System.Drawing.Size(114, 34);
            this.clearDayBttn.TabIndex = 3;
            this.clearDayBttn.Text = "Clear History Of A Day";
            this.clearDayBttn.UseVisualStyleBackColor = true;
            this.clearDayBttn.Click += new System.EventHandler(this.clearDayBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 209);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double-click URL\r\nto open it";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // printToolStrip
            // 
            this.printToolStrip.Name = "printToolStrip";
            this.printToolStrip.Size = new System.Drawing.Size(32, 22);
            this.printToolStrip.Text = "Print";
            this.printToolStrip.Click += new System.EventHandler(this.printToolStrip_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearDayBttn);
            this.Controls.Add(this.clearHistoryBttn);
            this.Controls.Add(this.histLabel);
            this.Controls.Add(this.listOfItems);
            this.Name = "History";
            this.Size = new System.Drawing.Size(614, 537);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfItems;
        private System.Windows.Forms.Label histLabel;
        private System.Windows.Forms.Button clearHistoryBttn;
        private System.Windows.Forms.Button clearDayBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel printToolStrip;
    }
}