namespace MainAndDialogForms
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
            this.oathUserControl = new ControlLibraryAssign3.OathUserControl();
            this.dialogBaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Controls.Add(this.oathUserControl);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(631, 79);
            // 
            // oathUserControl
            // 
            this.oathUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oathUserControl.BackColor = System.Drawing.Color.Transparent;
            this.oathUserControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.oathUserControl.Location = new System.Drawing.Point(87, 36);
            this.oathUserControl.Name = "oathUserControl";
            this.oathUserControl.Size = new System.Drawing.Size(495, 59);
            this.oathUserControl.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainAndDialogForms.Properties.Resources.bgImage;
            this.ClientSize = new System.Drawing.Size(631, 174);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.ShowIcon = false;
            this.Text = "Oath Dialog";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibraryAssign3.OathUserControl oathUserControl;
    }
}