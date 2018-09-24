namespace MainAndDialogForms
{
    partial class LoginDialog
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
            this.skipDialogCheckbox = new System.Windows.Forms.CheckBox();
            this.yesBttn = new System.Windows.Forms.Button();
            this.noBttn = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skipDialogCheckbox
            // 
            this.skipDialogCheckbox.AutoSize = true;
            this.skipDialogCheckbox.Location = new System.Drawing.Point(66, 70);
            this.skipDialogCheckbox.Name = "skipDialogCheckbox";
            this.skipDialogCheckbox.Size = new System.Drawing.Size(214, 21);
            this.skipDialogCheckbox.TabIndex = 0;
            this.skipDialogCheckbox.Text = "Skip this screen in the future.";
            this.skipDialogCheckbox.UseVisualStyleBackColor = true;
            this.skipDialogCheckbox.CheckedChanged += new System.EventHandler(this.skipDialogCheckbox_CheckedChanged);
            // 
            // yesBttn
            // 
            this.yesBttn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesBttn.Location = new System.Drawing.Point(89, 111);
            this.yesBttn.Name = "yesBttn";
            this.yesBttn.Size = new System.Drawing.Size(75, 23);
            this.yesBttn.TabIndex = 1;
            this.yesBttn.Text = "Yes";
            this.yesBttn.UseVisualStyleBackColor = true;
            // 
            // noBttn
            // 
            this.noBttn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noBttn.Location = new System.Drawing.Point(182, 111);
            this.noBttn.Name = "noBttn";
            this.noBttn.Size = new System.Drawing.Size(75, 23);
            this.noBttn.TabIndex = 1;
            this.noBttn.Text = "No";
            this.noBttn.UseVisualStyleBackColor = true;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(7, 27);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(341, 17);
            this.warningLabel.TabIndex = 2;
            this.warningLabel.Text = "Are you sure you want to continue with our program?";
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 161);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.noBttn);
            this.Controls.Add(this.yesBttn);
            this.Controls.Add(this.skipDialogCheckbox);
            this.Name = "LoginDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox skipDialogCheckbox;
        private System.Windows.Forms.Button yesBttn;
        private System.Windows.Forms.Button noBttn;
        private System.Windows.Forms.Label warningLabel;
    }
}