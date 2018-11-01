namespace TextThreadProgram
{
    partial class SearchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDialog));
            this.listBoxAllFiles = new System.Windows.Forms.ListBox();
            this.startSearchBttn = new System.Windows.Forms.Button();
            this.stopSearchBttn = new System.Windows.Forms.Button();
            this.pauseSearchBttn = new System.Windows.Forms.Button();
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxAllFiles
            // 
            this.listBoxAllFiles.FormattingEnabled = true;
            this.listBoxAllFiles.ItemHeight = 16;
            this.listBoxAllFiles.Location = new System.Drawing.Point(148, 65);
            this.listBoxAllFiles.MinimumSize = new System.Drawing.Size(252, 164);
            this.listBoxAllFiles.Name = "listBoxAllFiles";
            this.listBoxAllFiles.Size = new System.Drawing.Size(252, 164);
            this.listBoxAllFiles.TabIndex = 0;
            // 
            // startSearchBttn
            // 
            this.startSearchBttn.Location = new System.Drawing.Point(111, 258);
            this.startSearchBttn.MinimumSize = new System.Drawing.Size(105, 23);
            this.startSearchBttn.Name = "startSearchBttn";
            this.startSearchBttn.Size = new System.Drawing.Size(105, 23);
            this.startSearchBttn.TabIndex = 1;
            this.startSearchBttn.Text = "Start Search";
            this.startSearchBttn.UseVisualStyleBackColor = true;
            this.startSearchBttn.Click += new System.EventHandler(this.startSearchBttn_Click);
            // 
            // stopSearchBttn
            // 
            this.stopSearchBttn.Enabled = false;
            this.stopSearchBttn.Location = new System.Drawing.Point(222, 258);
            this.stopSearchBttn.MinimumSize = new System.Drawing.Size(105, 23);
            this.stopSearchBttn.Name = "stopSearchBttn";
            this.stopSearchBttn.Size = new System.Drawing.Size(105, 23);
            this.stopSearchBttn.TabIndex = 1;
            this.stopSearchBttn.Text = "Stop Search";
            this.stopSearchBttn.UseVisualStyleBackColor = true;
            this.stopSearchBttn.Click += new System.EventHandler(this.stopSearchBttn_Click);
            // 
            // pauseSearchBttn
            // 
            this.pauseSearchBttn.Enabled = false;
            this.pauseSearchBttn.Location = new System.Drawing.Point(333, 258);
            this.pauseSearchBttn.MinimumSize = new System.Drawing.Size(105, 23);
            this.pauseSearchBttn.Name = "pauseSearchBttn";
            this.pauseSearchBttn.Size = new System.Drawing.Size(105, 23);
            this.pauseSearchBttn.TabIndex = 1;
            this.pauseSearchBttn.Text = "Pause Search";
            this.pauseSearchBttn.UseVisualStyleBackColor = true;
            this.pauseSearchBttn.Click += new System.EventHandler(this.pauseSearchBttn_Click);
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Items.AddRange(new object[] {
            ".ok",
            ".txt",
            ".html",
            ".htm",
            ".*"});
            this.comboBoxExtension.Location = new System.Drawing.Point(148, 300);
            this.comboBoxExtension.MinimumSize = new System.Drawing.Size(252, 0);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(252, 24);
            this.comboBoxExtension.TabIndex = 2;
            this.comboBoxExtension.SelectedIndexChanged += new System.EventHandler(this.comboBoxExtension_SelectedIndexChanged);
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(542, 440);
            this.Controls.Add(this.comboBoxExtension);
            this.Controls.Add(this.pauseSearchBttn);
            this.Controls.Add(this.stopSearchBttn);
            this.Controls.Add(this.startSearchBttn);
            this.Controls.Add(this.listBoxAllFiles);
            this.MinimumSize = new System.Drawing.Size(560, 487);
            this.Name = "SearchDialog";
            this.Text = "Search Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDialog_FormClosing);
            this.Controls.SetChildIndex(this.listBoxAllFiles, 0);
            this.Controls.SetChildIndex(this.startSearchBttn, 0);
            this.Controls.SetChildIndex(this.stopSearchBttn, 0);
            this.Controls.SetChildIndex(this.pauseSearchBttn, 0);
            this.Controls.SetChildIndex(this.comboBoxExtension, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllFiles;
        private System.Windows.Forms.Button startSearchBttn;
        private System.Windows.Forms.Button stopSearchBttn;
        private System.Windows.Forms.Button pauseSearchBttn;
        private System.Windows.Forms.ComboBox comboBoxExtension;
    }
}