namespace TextThreadProgram
{
    partial class ChangeColorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeColorDialog));
            this.newColorBttn = new System.Windows.Forms.Button();
            this.oldColorBttn = new System.Windows.Forms.Button();
            this.oldColorLabelDisplay = new System.Windows.Forms.Label();
            this.newColorLabelDisplay = new System.Windows.Forms.Label();
            this.colorApplyBttn = new System.Windows.Forms.Button();
            this.cancelColorBttn = new System.Windows.Forms.Button();
            this.okayColorBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newColorBttn
            // 
            this.newColorBttn.Location = new System.Drawing.Point(297, 155);
            this.newColorBttn.MinimumSize = new System.Drawing.Size(126, 32);
            this.newColorBttn.Name = "newColorBttn";
            this.newColorBttn.Size = new System.Drawing.Size(126, 32);
            this.newColorBttn.TabIndex = 2;
            this.newColorBttn.Text = "New Color";
            this.newColorBttn.UseVisualStyleBackColor = true;
            this.newColorBttn.Click += new System.EventHandler(this.newColorBttn_Click);
            // 
            // oldColorBttn
            // 
            this.oldColorBttn.Location = new System.Drawing.Point(106, 155);
            this.oldColorBttn.MinimumSize = new System.Drawing.Size(126, 32);
            this.oldColorBttn.Name = "oldColorBttn";
            this.oldColorBttn.Size = new System.Drawing.Size(126, 32);
            this.oldColorBttn.TabIndex = 2;
            this.oldColorBttn.Text = "Color to change";
            this.oldColorBttn.UseVisualStyleBackColor = true;
            this.oldColorBttn.Click += new System.EventHandler(this.oldColorBttn_Click);
            // 
            // oldColorLabelDisplay
            // 
            this.oldColorLabelDisplay.Location = new System.Drawing.Point(106, 122);
            this.oldColorLabelDisplay.MinimumSize = new System.Drawing.Size(126, 32);
            this.oldColorLabelDisplay.Name = "oldColorLabelDisplay";
            this.oldColorLabelDisplay.Size = new System.Drawing.Size(126, 32);
            this.oldColorLabelDisplay.TabIndex = 0;
            // 
            // newColorLabelDisplay
            // 
            this.newColorLabelDisplay.Location = new System.Drawing.Point(297, 122);
            this.newColorLabelDisplay.MinimumSize = new System.Drawing.Size(126, 32);
            this.newColorLabelDisplay.Name = "newColorLabelDisplay";
            this.newColorLabelDisplay.Size = new System.Drawing.Size(126, 32);
            this.newColorLabelDisplay.TabIndex = 0;
            // 
            // colorApplyBttn
            // 
            this.colorApplyBttn.Location = new System.Drawing.Point(203, 215);
            this.colorApplyBttn.MinimumSize = new System.Drawing.Size(126, 32);
            this.colorApplyBttn.Name = "colorApplyBttn";
            this.colorApplyBttn.Size = new System.Drawing.Size(126, 32);
            this.colorApplyBttn.TabIndex = 3;
            this.colorApplyBttn.Text = "Apply Color";
            this.colorApplyBttn.UseVisualStyleBackColor = true;
            this.colorApplyBttn.Click += new System.EventHandler(this.colorApplyBttn_Click);
            // 
            // cancelColorBttn
            // 
            this.cancelColorBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelColorBttn.Location = new System.Drawing.Point(335, 215);
            this.cancelColorBttn.MinimumSize = new System.Drawing.Size(126, 32);
            this.cancelColorBttn.Name = "cancelColorBttn";
            this.cancelColorBttn.Size = new System.Drawing.Size(126, 32);
            this.cancelColorBttn.TabIndex = 3;
            this.cancelColorBttn.Text = "Cancel";
            this.cancelColorBttn.UseVisualStyleBackColor = true;
            this.cancelColorBttn.Click += new System.EventHandler(this.cancelColorBttn_Click);
            // 
            // okayColorBttn
            // 
            this.okayColorBttn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayColorBttn.Location = new System.Drawing.Point(71, 215);
            this.okayColorBttn.MinimumSize = new System.Drawing.Size(126, 32);
            this.okayColorBttn.Name = "okayColorBttn";
            this.okayColorBttn.Size = new System.Drawing.Size(126, 32);
            this.okayColorBttn.TabIndex = 3;
            this.okayColorBttn.Text = "Okay";
            this.okayColorBttn.UseVisualStyleBackColor = true;
            this.okayColorBttn.Click += new System.EventHandler(this.okayColorBttn_Click);
            // 
            // ChangeColorDialog
            // 
            this.AcceptButton = this.okayColorBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.cancelColorBttn;
            this.ClientSize = new System.Drawing.Size(532, 369);
            this.Controls.Add(this.cancelColorBttn);
            this.Controls.Add(this.okayColorBttn);
            this.Controls.Add(this.colorApplyBttn);
            this.Controls.Add(this.newColorLabelDisplay);
            this.Controls.Add(this.oldColorLabelDisplay);
            this.Controls.Add(this.oldColorBttn);
            this.Controls.Add(this.newColorBttn);
            this.Name = "ChangeColorDialog";
            this.Text = "ChangeColorDialog";
            this.Controls.SetChildIndex(this.newColorBttn, 0);
            this.Controls.SetChildIndex(this.oldColorBttn, 0);
            this.Controls.SetChildIndex(this.oldColorLabelDisplay, 0);
            this.Controls.SetChildIndex(this.newColorLabelDisplay, 0);
            this.Controls.SetChildIndex(this.colorApplyBttn, 0);
            this.Controls.SetChildIndex(this.okayColorBttn, 0);
            this.Controls.SetChildIndex(this.cancelColorBttn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newColorBttn;
        private System.Windows.Forms.Button oldColorBttn;
        private System.Windows.Forms.Label oldColorLabelDisplay;
        private System.Windows.Forms.Label newColorLabelDisplay;
        private System.Windows.Forms.Button colorApplyBttn;
        private System.Windows.Forms.Button cancelColorBttn;
        private System.Windows.Forms.Button okayColorBttn;
    }
}