﻿namespace MainAndDialogForms
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
            this.toolTipRect = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEllp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRatio = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipApply = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCancel = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
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
            this.dialogBaseFormPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(649, 204);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.Location = new System.Drawing.Point(396, 156);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(70, 25);
            this.okayButton.TabIndex = 0;
            this.okayButton.Text = "OK";
            this.toolTipOK.SetToolTip(this.okayButton, "Click to apply changes and close Preferences");
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(472, 156);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(70, 25);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.toolTipApply.SetToolTip(this.applyButton, "Click to apply changes");
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(548, 156);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.toolTipCancel.SetToolTip(this.cancelButton, "Click to close Preferences");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RectBox
            // 
            this.RectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectBox.Location = new System.Drawing.Point(146, 18);
            this.RectBox.Name = "RectBox";
            this.RectBox.Size = new System.Drawing.Size(411, 20);
            this.RectBox.TabIndex = 3;
            this.toolTipRect.SetToolTip(this.RectBox, "Height of Rectangle must be a positive integer greater than 0\r\n(ex: 1, 2, 3, 4, 5" +
        "...)");
            // 
            // EllipText
            // 
            this.EllipText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EllipText.Location = new System.Drawing.Point(146, 59);
            this.EllipText.Name = "EllipText";
            this.EllipText.Size = new System.Drawing.Size(411, 20);
            this.EllipText.TabIndex = 4;
            this.toolTipEllp.SetToolTip(this.EllipText, "Width of Ellipse must be a positive integer greater than 0\r\n(ex: 1, 2, 3, 4, 5..." +
        ")");
            // 
            // RatioText
            // 
            this.RatioText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RatioText.Location = new System.Drawing.Point(146, 100);
            this.RatioText.Name = "RatioText";
            this.RatioText.Size = new System.Drawing.Size(411, 20);
            this.RatioText.TabIndex = 5;
            this.toolTipRatio.SetToolTip(this.RatioText, "Ratio must be a positive floating point number greater than 0\r\n(ex: 0.5, 1.0, 2.5" +
        ", 3.75, 3.141526...)");
            // 
            // RectLabel
            // 
            this.RectLabel.AutoSize = true;
            this.RectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectLabel.Location = new System.Drawing.Point(29, 19);
            this.RectLabel.Name = "RectLabel";
            this.RectLabel.Size = new System.Drawing.Size(111, 15);
            this.RectLabel.TabIndex = 6;
            this.RectLabel.Text = "Rectangle Height : ";
            // 
            // EllipLabel
            // 
            this.EllipLabel.AutoSize = true;
            this.EllipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EllipLabel.Location = new System.Drawing.Point(53, 60);
            this.EllipLabel.Name = "EllipLabel";
            this.EllipLabel.Size = new System.Drawing.Size(87, 15);
            this.EllipLabel.TabIndex = 7;
            this.EllipLabel.Text = "Ellipse Width : ";
            // 
            // RatioLabel
            // 
            this.RatioLabel.AutoSize = true;
            this.RatioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatioLabel.Location = new System.Drawing.Point(22, 101);
            this.RatioLabel.Name = "RatioLabel";
            this.RatioLabel.Size = new System.Drawing.Size(118, 15);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainAndDialogForms.Properties.Resources.BackgroundImage1;
            this.ClientSize = new System.Drawing.Size(649, 299);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrefDialog";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Preferences";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PrefDialog_Load);
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
        private System.Windows.Forms.ToolTip toolTipRect;
        private System.Windows.Forms.ToolTip toolTipRatio;
        private System.Windows.Forms.ToolTip toolTipEllp;
        private System.Windows.Forms.ToolTip toolTipCancel;
        private System.Windows.Forms.ToolTip toolTipApply;
        private System.Windows.Forms.ToolTip toolTipOK;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}