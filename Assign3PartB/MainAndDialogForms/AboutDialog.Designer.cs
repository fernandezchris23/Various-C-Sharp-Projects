namespace MainAndDialogForms
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
            this.assignDescrip = new System.Windows.Forms.Label();
            this.dialogBaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Controls.Add(this.assignDescrip);
            this.dialogBaseFormPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(778, 182);
            // 
            // assignDescrip
            // 
            this.assignDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignDescrip.AutoSize = true;
            this.assignDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignDescrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.assignDescrip.Location = new System.Drawing.Point(3, 56);
            this.assignDescrip.Name = "assignDescrip";
            this.assignDescrip.Size = new System.Drawing.Size(770, 72);
            this.assignDescrip.TabIndex = 0;
            this.assignDescrip.Text = "Assignment 4 is an extension of assignment 3 and is adding various dialogs and a " +
    "control\nto the project as well as converting the Main form into an MDI parent an" +
    "d adding the shapes\nas its children.";
            this.assignDescrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::MainAndDialogForms.Properties.Resources.bgImage;
            this.ClientSize = new System.Drawing.Size(778, 277);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.Text = "About Assignment";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.dialogBaseFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label assignDescrip;
    }
}