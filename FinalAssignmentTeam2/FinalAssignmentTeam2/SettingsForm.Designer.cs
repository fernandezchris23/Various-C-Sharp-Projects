namespace FinalAssignmentTeam2
{
    partial class SettingsForm
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
            this.homePageLabel = new System.Windows.Forms.Label();
            this.homePageTextBox = new System.Windows.Forms.TextBox();
            this.numMinutesNotifyLabel = new System.Windows.Forms.Label();
            this.numMinutesNotifyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okBttn = new System.Windows.Forms.Button();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.notifyCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesNotifyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // homePageLabel
            // 
            this.homePageLabel.AutoSize = true;
            this.homePageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageLabel.Location = new System.Drawing.Point(55, 42);
            this.homePageLabel.Name = "homePageLabel";
            this.homePageLabel.Size = new System.Drawing.Size(155, 16);
            this.homePageLabel.TabIndex = 0;
            this.homePageLabel.Text = "Set Home Page URL:";
            // 
            // homePageTextBox
            // 
            this.homePageTextBox.Location = new System.Drawing.Point(219, 41);
            this.homePageTextBox.Name = "homePageTextBox";
            this.homePageTextBox.Size = new System.Drawing.Size(265, 20);
            this.homePageTextBox.TabIndex = 1;
            // 
            // numMinutesNotifyLabel
            // 
            this.numMinutesNotifyLabel.AutoSize = true;
            this.numMinutesNotifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinutesNotifyLabel.Location = new System.Drawing.Point(115, 90);
            this.numMinutesNotifyLabel.Name = "numMinutesNotifyLabel";
            this.numMinutesNotifyLabel.Size = new System.Drawing.Size(218, 16);
            this.numMinutesNotifyLabel.TabIndex = 5;
            this.numMinutesNotifyLabel.Text = "Minutes Between Notifications:";
            // 
            // numMinutesNotifyNumericUpDown
            // 
            this.numMinutesNotifyNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinutesNotifyNumericUpDown.Location = new System.Drawing.Point(347, 87);
            this.numMinutesNotifyNumericUpDown.Name = "numMinutesNotifyNumericUpDown";
            this.numMinutesNotifyNumericUpDown.Size = new System.Drawing.Size(47, 22);
            this.numMinutesNotifyNumericUpDown.TabIndex = 8;
            this.numMinutesNotifyNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // okBttn
            // 
            this.okBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBttn.Location = new System.Drawing.Point(409, 162);
            this.okBttn.Name = "okBttn";
            this.okBttn.Size = new System.Drawing.Size(75, 23);
            this.okBttn.TabIndex = 10;
            this.okBttn.Text = "OK";
            this.okBttn.UseVisualStyleBackColor = true;
            this.okBttn.Click += new System.EventHandler(this.okBttn_Click);
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyLabel.Location = new System.Drawing.Point(200, 133);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(151, 16);
            this.notifyLabel.TabIndex = 4;
            this.notifyLabel.Text = "Enable Notifications:";
            // 
            // notifyCheckBox
            // 
            this.notifyCheckBox.AutoSize = true;
            this.notifyCheckBox.Location = new System.Drawing.Point(358, 133);
            this.notifyCheckBox.Name = "notifyCheckBox";
            this.notifyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.notifyCheckBox.TabIndex = 11;
            this.notifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 205);
            this.Controls.Add(this.notifyCheckBox);
            this.Controls.Add(this.okBttn);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.numMinutesNotifyNumericUpDown);
            this.Controls.Add(this.numMinutesNotifyLabel);
            this.Controls.Add(this.homePageTextBox);
            this.Controls.Add(this.homePageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesNotifyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homePageLabel;
        private System.Windows.Forms.TextBox homePageTextBox;
        private System.Windows.Forms.Label numMinutesNotifyLabel;
        private System.Windows.Forms.NumericUpDown numMinutesNotifyNumericUpDown;
        private System.Windows.Forms.Button okBttn;
        private System.Windows.Forms.Label notifyLabel;
        private System.Windows.Forms.CheckBox notifyCheckBox;
    }
}