namespace TextThreadProgram
{
    partial class TextOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextOptions));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.propertyTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Text",
            "Font",
            "Text Color",
            "Background Color",
            "Z-Order",
            "Rotation",
            "Location"});
            this.comboBox1.Location = new System.Drawing.Point(56, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Choose Property...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(247, 181);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(89, 30);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(354, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 30);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(140, 181);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(89, 30);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // propertyTextBox
            // 
            this.propertyTextBox.Location = new System.Drawing.Point(231, 132);
            this.propertyTextBox.Name = "propertyTextBox";
            this.propertyTextBox.Size = new System.Drawing.Size(131, 22);
            this.propertyTextBox.TabIndex = 4;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(393, 130);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(89, 30);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Change...";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // TextOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 341);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.propertyTextBox);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "TextOptions";
            this.Text = "Text Options";
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.applyButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.okayButton, 0);
            this.Controls.SetChildIndex(this.propertyTextBox, 0);
            this.Controls.SetChildIndex(this.changeButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.TextBox propertyTextBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}