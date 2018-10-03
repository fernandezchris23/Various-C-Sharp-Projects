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
            this.dialogBaseFormPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(465, 101);
            // 
            // oathUserControl1
            // 
            this.oathUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathUserControl1.Location = new System.Drawing.Point(0, 0);
            this.oathUserControl1.Name = "oathUserControl1";
            this.oathUserControl1.Size = new System.Drawing.Size(465, 101);
            this.oathUserControl1.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDI_Text_Editor.Properties.Resources.smiles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 196);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(476, 211);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.OathUserControl oathUserControl1;
    }
}