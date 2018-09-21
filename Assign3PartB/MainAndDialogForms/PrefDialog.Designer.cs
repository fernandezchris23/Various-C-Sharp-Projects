namespace MainAndDialogForms
{
    partial class PrefDialog
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.okayButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.RectBox = new System.Windows.Forms.TextBox();
            this.EllipText = new System.Windows.Forms.TextBox();
            this.RatioText = new System.Windows.Forms.TextBox();
            this.RectLabel = new System.Windows.Forms.Label();
            this.EllipLabel = new System.Windows.Forms.Label();
            this.RatioLabel = new System.Windows.Forms.Label();
            this.RectError = new System.Windows.Forms.ErrorProvider(this.components);
            this.EllipError = new System.Windows.Forms.ErrorProvider(this.components);
            this.RatioError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dialogBaseFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatioError)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.dialogBaseFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dialogBaseFormPanel.Controls.Add(this.RatioLabel);
            this.dialogBaseFormPanel.Controls.Add(this.EllipLabel);
            this.dialogBaseFormPanel.Controls.Add(this.RectLabel);
            this.dialogBaseFormPanel.Controls.Add(this.RatioText);
            this.dialogBaseFormPanel.Controls.Add(this.EllipText);
            this.dialogBaseFormPanel.Controls.Add(this.RectBox);
            this.dialogBaseFormPanel.Controls.Add(this.cancelButton);
            this.dialogBaseFormPanel.Controls.Add(this.applyButton);
            this.dialogBaseFormPanel.Controls.Add(this.okayButton);
            this.dialogBaseFormPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(865, 251);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okayButton.Location = new System.Drawing.Point(160, 192);
            this.okayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(93, 31);
            this.okayButton.TabIndex = 0;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.applyButton.Location = new System.Drawing.Point(385, 192);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(93, 31);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(609, 192);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 31);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RectBox
            // 
            this.RectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectBox.Location = new System.Drawing.Point(195, 22);
            this.RectBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RectBox.Name = "RectBox";
            this.RectBox.Size = new System.Drawing.Size(548, 22);
            this.RectBox.TabIndex = 3;
            // 
            // EllipText
            // 
            this.EllipText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EllipText.Location = new System.Drawing.Point(195, 73);
            this.EllipText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EllipText.Name = "EllipText";
            this.EllipText.Size = new System.Drawing.Size(548, 22);
            this.EllipText.TabIndex = 4;
            // 
            // RatioText
            // 
            this.RatioText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RatioText.Location = new System.Drawing.Point(195, 123);
            this.RatioText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RatioText.Name = "RatioText";
            this.RatioText.Size = new System.Drawing.Size(548, 22);
            this.RatioText.TabIndex = 5;
            // 
            // RectLabel
            // 
            this.RectLabel.AutoSize = true;
            this.RectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectLabel.Location = new System.Drawing.Point(39, 23);
            this.RectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectLabel.Name = "RectLabel";
            this.RectLabel.Size = new System.Drawing.Size(132, 18);
            this.RectLabel.TabIndex = 6;
            this.RectLabel.Text = "Rectangle Height : ";
            // 
            // EllipLabel
            // 
            this.EllipLabel.AutoSize = true;
            this.EllipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EllipLabel.Location = new System.Drawing.Point(71, 74);
            this.EllipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EllipLabel.Name = "EllipLabel";
            this.EllipLabel.Size = new System.Drawing.Size(105, 18);
            this.EllipLabel.TabIndex = 7;
            this.EllipLabel.Text = "Ellipse Width : ";
            // 
            // RatioLabel
            // 
            this.RatioLabel.AutoSize = true;
            this.RatioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatioLabel.Location = new System.Drawing.Point(29, 124);
            this.RatioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatioLabel.Name = "RatioLabel";
            this.RatioLabel.Size = new System.Drawing.Size(143, 18);
            this.RatioLabel.TabIndex = 8;
            this.RatioLabel.Text = "Height Width Ratio : ";
            // 
            // RectError
            // 
            this.RectError.ContainerControl = this;
            // 
            // EllipError
            // 
            this.EllipError.ContainerControl = this;
            // 
            // RatioError
            // 
            this.RatioError.ContainerControl = this;
            // 
            // PrefDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainAndDialogForms.Properties.Resources.BackgroundImage1;
            this.ClientSize = new System.Drawing.Size(865, 368);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PrefDialog";
            this.Text = "Preferences";
            this.TopMost = true;
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.dialogBaseFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatioError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label RatioLabel;
        private System.Windows.Forms.Label EllipLabel;
        private System.Windows.Forms.Label RectLabel;
        private System.Windows.Forms.TextBox RatioText;
        private System.Windows.Forms.TextBox EllipText;
        private System.Windows.Forms.TextBox RectBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.ErrorProvider RectError;
        private System.Windows.Forms.ErrorProvider EllipError;
        private System.Windows.Forms.ErrorProvider RatioError;
    }
}