namespace Multi_SDI_Application
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(723, 288);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 43);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.MinimumSize = new System.Drawing.Size(602, 171);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(723, 288);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 383);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "AboutDialog";
            this.Text = "AboutDialog";
            this.Controls.SetChildIndex(this.dialogBaseFormPanel, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
    }
}