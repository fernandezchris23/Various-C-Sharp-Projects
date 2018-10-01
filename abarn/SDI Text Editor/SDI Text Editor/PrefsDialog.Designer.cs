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
            this.changeFontButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.currentFontLabel = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.currentFontTextBox = new System.Windows.Forms.TextBox();
            this.currentColorTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backColorBox = new System.Windows.Forms.TextBox();
            this.changeBackColorButton = new System.Windows.Forms.Button();
            this.dialogBaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Controls.Add(this.changeBackColorButton);
            this.dialogBaseFormPanel.Controls.Add(this.backColorBox);
            this.dialogBaseFormPanel.Controls.Add(this.label2);
            this.dialogBaseFormPanel.Controls.Add(this.label1);
            this.dialogBaseFormPanel.Controls.Add(this.currentColorTextBox);
            this.dialogBaseFormPanel.Controls.Add(this.currentFontTextBox);
            this.dialogBaseFormPanel.Controls.Add(this.currentFontLabel);
            this.dialogBaseFormPanel.Controls.Add(this.okayButton);
            this.dialogBaseFormPanel.Controls.Add(this.cancelButton);
            this.dialogBaseFormPanel.Controls.Add(this.changeFontButton);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(545, 374);
            // 
            // changeFontButton
            // 
            this.changeFontButton.Location = new System.Drawing.Point(371, 39);
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.Size = new System.Drawing.Size(104, 67);
            this.changeFontButton.TabIndex = 0;
            this.changeFontButton.Text = "Change Font/Color...";
            this.changeFontButton.UseVisualStyleBackColor = true;
            this.changeFontButton.Click += new System.EventHandler(this.changeFontButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(336, 275);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(40, 275);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(139, 50);
            this.okayButton.TabIndex = 2;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // currentFontLabel
            // 
            this.currentFontLabel.AutoSize = true;
            this.currentFontLabel.Location = new System.Drawing.Point(55, 39);
            this.currentFontLabel.Name = "currentFontLabel";
            this.currentFontLabel.Size = new System.Drawing.Size(87, 17);
            this.currentFontLabel.TabIndex = 3;
            this.currentFontLabel.Text = "Current Font";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // currentFontTextBox
            // 
            this.currentFontTextBox.Location = new System.Drawing.Point(166, 26);
            this.currentFontTextBox.Multiline = true;
            this.currentFontTextBox.Name = "currentFontTextBox";
            this.currentFontTextBox.ReadOnly = true;
            this.currentFontTextBox.Size = new System.Drawing.Size(174, 44);
            this.currentFontTextBox.TabIndex = 4;
            // 
            // currentColorTextBox
            // 
            this.currentColorTextBox.Location = new System.Drawing.Point(167, 86);
            this.currentColorTextBox.Name = "currentColorTextBox";
            this.currentColorTextBox.ReadOnly = true;
            this.currentColorTextBox.Size = new System.Drawing.Size(173, 22);
            this.currentColorTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Font Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Background Color:";
            // 
            // backColorBox
            // 
            this.backColorBox.Location = new System.Drawing.Point(166, 162);
            this.backColorBox.Multiline = true;
            this.backColorBox.Name = "backColorBox";
            this.backColorBox.ReadOnly = true;
            this.backColorBox.Size = new System.Drawing.Size(173, 45);
            this.backColorBox.TabIndex = 9;
            // 
            // changeBackColorButton
            // 
            this.changeBackColorButton.Location = new System.Drawing.Point(371, 165);
            this.changeBackColorButton.Name = "changeBackColorButton";
            this.changeBackColorButton.Size = new System.Drawing.Size(104, 34);
            this.changeBackColorButton.TabIndex = 10;
            this.changeBackColorButton.Text = "Change...";
            this.changeBackColorButton.UseVisualStyleBackColor = true;
            this.changeBackColorButton.Click += new System.EventHandler(this.changeBackColorButton_Click);
            // 
            // PrefsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 491);
            this.Name = "PrefsDialog";
            this.Text = "PrefsDialog";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.dialogBaseFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentFontLabel;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeFontButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TextBox currentFontTextBox;
        private System.Windows.Forms.TextBox currentColorTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeBackColorButton;
        private System.Windows.Forms.TextBox backColorBox;
        private System.Windows.Forms.Label label2;
    }
}