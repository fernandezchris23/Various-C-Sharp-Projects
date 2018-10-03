namespace SDI_Text_Editor
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
            this.oathUserControl1 = new ControlLibrary.OathUserControl();
            this.dialogBaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Controls.Add(this.oathUserControl1);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(708, 125);
            // 
            // oathUserControl1
            // 
            this.oathUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathUserControl1.Location = new System.Drawing.Point(0, 0);
            this.oathUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.oathUserControl1.Name = "oathUserControl1";
            this.oathUserControl1.Size = new System.Drawing.Size(708, 125);
            this.oathUserControl1.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 242);
            this.MinimumSize = new System.Drawing.Size(630, 251);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.OathUserControl oathUserControl1;
    }
}