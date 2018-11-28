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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printToolStrip = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesNotifyNumericUpDown)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePageLabel
            // 
            this.homePageLabel.AutoSize = true;
            this.homePageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageLabel.Location = new System.Drawing.Point(117, 52);
            this.homePageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.homePageLabel.Name = "homePageLabel";
            this.homePageLabel.Size = new System.Drawing.Size(189, 20);
            this.homePageLabel.TabIndex = 0;
            this.homePageLabel.Text = "Set Home Page URL:";
            // 
            // homePageTextBox
            // 
            this.homePageTextBox.Location = new System.Drawing.Point(341, 52);
            this.homePageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homePageTextBox.Name = "homePageTextBox";
            this.homePageTextBox.Size = new System.Drawing.Size(352, 22);
            this.homePageTextBox.TabIndex = 1;
            // 
            // numMinutesNotifyLabel
            // 
            this.numMinutesNotifyLabel.AutoSize = true;
            this.numMinutesNotifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinutesNotifyLabel.Location = new System.Drawing.Point(35, 94);
            this.numMinutesNotifyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numMinutesNotifyLabel.Name = "numMinutesNotifyLabel";
            this.numMinutesNotifyLabel.Size = new System.Drawing.Size(271, 20);
            this.numMinutesNotifyLabel.TabIndex = 5;
            this.numMinutesNotifyLabel.Text = "Minutes Between Notifications:";
            // 
            // numMinutesNotifyNumericUpDown
            // 
            this.numMinutesNotifyNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinutesNotifyNumericUpDown.Location = new System.Drawing.Point(341, 94);
            this.numMinutesNotifyNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMinutesNotifyNumericUpDown.Name = "numMinutesNotifyNumericUpDown";
            this.numMinutesNotifyNumericUpDown.Size = new System.Drawing.Size(63, 26);
            this.numMinutesNotifyNumericUpDown.TabIndex = 8;
            this.numMinutesNotifyNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // okBttn
            // 
            this.okBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBttn.Location = new System.Drawing.Point(566, 148);
            this.okBttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okBttn.Name = "okBttn";
            this.okBttn.Size = new System.Drawing.Size(100, 28);
            this.okBttn.TabIndex = 10;
            this.okBttn.Text = "OK";
            this.okBttn.UseVisualStyleBackColor = true;
            this.okBttn.Click += new System.EventHandler(this.okBttn_Click);
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyLabel.Location = new System.Drawing.Point(122, 131);
            this.notifyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(184, 20);
            this.notifyLabel.TabIndex = 4;
            this.notifyLabel.Text = "Enable Notifications:";
            // 
            // notifyCheckBox
            // 
            this.notifyCheckBox.AutoSize = true;
            this.notifyCheckBox.Location = new System.Drawing.Point(341, 135);
            this.notifyCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notifyCheckBox.Name = "notifyCheckBox";
            this.notifyCheckBox.Size = new System.Drawing.Size(18, 17);
            this.notifyCheckBox.TabIndex = 11;
            this.notifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // printToolStrip
            // 
            this.printToolStrip.Name = "printToolStrip";
            this.printToolStrip.Size = new System.Drawing.Size(39, 22);
            this.printToolStrip.Text = "Print";
            this.printToolStrip.Click += new System.EventHandler(this.printToolStrip_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 233);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.notifyCheckBox);
            this.Controls.Add(this.okBttn);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.numMinutesNotifyNumericUpDown);
            this.Controls.Add(this.numMinutesNotifyLabel);
            this.Controls.Add(this.homePageTextBox);
            this.Controls.Add(this.homePageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesNotifyNumericUpDown)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel printToolStrip;
    }
}