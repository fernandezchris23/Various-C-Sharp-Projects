namespace TextThreadProgram
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
            this.aboutControl1 = new ControlLibrary.aboutControl();
            this.SuspendLayout();
            // 
            // aboutControl1
            // 
            this.aboutControl1.BackColor = System.Drawing.Color.Transparent;
            this.aboutControl1.Location = new System.Drawing.Point(0, 95);
            this.aboutControl1.Margin = new System.Windows.Forms.Padding(5);
            this.aboutControl1.MinimumSize = new System.Drawing.Size(368, 158);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(368, 158);
            this.aboutControl1.TabIndex = 4;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 429);
            this.Controls.Add(this.aboutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AboutDialog";
            this.Text = "About";
            this.Controls.SetChildIndex(this.aboutControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private ControlLibrary.aboutControl aboutControl1;
    }
}