namespace SDI_Text_Editor
{
    partial class PrefsDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrefsDialog));
            this.changeFontButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.currentFontLabel = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.currentFontTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.backColorBox = new System.Windows.Forms.TextBox();
            this.changeBackColorButton = new System.Windows.Forms.Button();
            this.applyBttn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.dialogBaseFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Controls.Add(this.applyBttn);
            this.dialogBaseFormPanel.Controls.Add(this.changeBackColorButton);
            this.dialogBaseFormPanel.Controls.Add(this.backColorBox);
            this.dialogBaseFormPanel.Controls.Add(this.label2);
            this.dialogBaseFormPanel.Controls.Add(this.currentFontTextBox);
            this.dialogBaseFormPanel.Controls.Add(this.currentFontLabel);
            this.dialogBaseFormPanel.Controls.Add(this.okayButton);
            this.dialogBaseFormPanel.Controls.Add(this.cancelButton);
            this.dialogBaseFormPanel.Controls.Add(this.changeFontButton);
            this.dialogBaseFormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(492, 198);
            // 
            // changeFontButton
            // 
            this.changeFontButton.Location = new System.Drawing.Point(314, 25);
            this.changeFontButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.Size = new System.Drawing.Size(106, 36);
            this.changeFontButton.TabIndex = 0;
            this.changeFontButton.Text = "Change Font and Color";
            this.changeFontButton.UseVisualStyleBackColor = true;
            this.changeFontButton.Click += new System.EventHandler(this.changeFontButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cancelButton.Location = new System.Drawing.Point(316, 140);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 41);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okayButton
            // 
            this.okayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okayButton.Location = new System.Drawing.Point(94, 140);
            this.okayButton.Margin = new System.Windows.Forms.Padding(2);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(104, 41);
            this.okayButton.TabIndex = 2;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // currentFontLabel
            // 
            this.currentFontLabel.AutoSize = true;
            this.currentFontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.currentFontLabel.Location = new System.Drawing.Point(36, 37);
            this.currentFontLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentFontLabel.Name = "currentFontLabel";
            this.currentFontLabel.Size = new System.Drawing.Size(82, 16);
            this.currentFontLabel.TabIndex = 3;
            this.currentFontLabel.Text = "Current Font:";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // currentFontTextBox
            // 
            this.currentFontTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentFontTextBox.Enabled = false;
            this.currentFontTextBox.Location = new System.Drawing.Point(124, 26);
            this.currentFontTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentFontTextBox.Multiline = true;
            this.currentFontTextBox.Name = "currentFontTextBox";
            this.currentFontTextBox.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.currentFontTextBox, true);
            this.currentFontTextBox.Size = new System.Drawing.Size(169, 36);
            this.currentFontTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Background Color:";
            // 
            // backColorBox
            // 
            this.backColorBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backColorBox.Enabled = false;
            this.backColorBox.Location = new System.Drawing.Point(124, 81);
            this.backColorBox.Margin = new System.Windows.Forms.Padding(2);
            this.backColorBox.Multiline = true;
            this.backColorBox.Name = "backColorBox";
            this.backColorBox.ReadOnly = true;
            this.helpProvider.SetShowHelp(this.backColorBox, true);
            this.backColorBox.Size = new System.Drawing.Size(169, 37);
            this.backColorBox.TabIndex = 9;
            // 
            // changeBackColorButton
            // 
            this.changeBackColorButton.Location = new System.Drawing.Point(327, 90);
            this.changeBackColorButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeBackColorButton.Name = "changeBackColorButton";
            this.changeBackColorButton.Size = new System.Drawing.Size(93, 28);
            this.changeBackColorButton.TabIndex = 10;
            this.changeBackColorButton.Text = "Change Value";
            this.changeBackColorButton.UseVisualStyleBackColor = true;
            this.changeBackColorButton.Click += new System.EventHandler(this.changeBackgroundColorButton_Click);
            // 
            // applyBttn
            // 
            this.applyBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.applyBttn.Location = new System.Drawing.Point(206, 140);
            this.applyBttn.Margin = new System.Windows.Forms.Padding(2);
            this.applyBttn.Name = "applyBttn";
            this.applyBttn.Size = new System.Drawing.Size(104, 41);
            this.applyBttn.TabIndex = 11;
            this.applyBttn.Text = "Apply";
            this.applyBttn.UseVisualStyleBackColor = true;
            this.applyBttn.Click += new System.EventHandler(this.applyBttn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PrefsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(492, 293);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(508, 332);
            this.Name = "PrefsDialog";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Preferences";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.dialogBaseFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentFontLabel;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeFontButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TextBox currentFontTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button changeBackColorButton;
        private System.Windows.Forms.TextBox backColorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applyBttn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}