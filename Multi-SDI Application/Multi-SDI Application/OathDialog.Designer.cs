namespace Multi_SDI_Application
{
    partial class OathDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OathDialog));
            this.oathUserControl1 = new ControlLibrary.OathUserControl();
            this.dialogBaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Controls.Add(this.oathUserControl1);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(711, 222);
            // 
            // oathUserControl1
            // 
            this.oathUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathUserControl1.Location = new System.Drawing.Point(26, 31);
            this.oathUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oathUserControl1.Name = "oathUserControl1";
            this.oathUserControl1.Size = new System.Drawing.Size(547, 91);
            this.oathUserControl1.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 317);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.OathUserControl oathUserControl1;
    }
}