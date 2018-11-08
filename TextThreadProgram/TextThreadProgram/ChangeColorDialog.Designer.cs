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
            this.SuspendLayout();
            // 
            // newColorBttn
            // 
            this.newColorBttn.Location = new System.Drawing.Point(302, 185);
            this.newColorBttn.MinimumSize = new System.Drawing.Size(116, 32);
            this.newColorBttn.Name = "newColorBttn";
            this.newColorBttn.Size = new System.Drawing.Size(116, 32);
            this.newColorBttn.TabIndex = 2;
            this.newColorBttn.Text = "New Color";
            this.newColorBttn.UseVisualStyleBackColor = true;
            this.newColorBttn.Click += new System.EventHandler(this.newColorBttn_Click);
            // 
            // oldColorBttn
            // 
            this.oldColorBttn.Location = new System.Drawing.Point(115, 185);
            this.oldColorBttn.MinimumSize = new System.Drawing.Size(116, 32);
            this.oldColorBttn.Name = "oldColorBttn";
            this.oldColorBttn.Size = new System.Drawing.Size(116, 32);
            this.oldColorBttn.TabIndex = 2;
            this.oldColorBttn.Text = "Color to change";
            this.oldColorBttn.UseVisualStyleBackColor = true;
            this.oldColorBttn.Click += new System.EventHandler(this.oldColorBttn_Click);
            // 
            // oldColorLabelDisplay
            // 
            this.oldColorLabelDisplay.Location = new System.Drawing.Point(115, 152);
            this.oldColorLabelDisplay.MinimumSize = new System.Drawing.Size(116, 32);
            this.oldColorLabelDisplay.Name = "oldColorLabelDisplay";
            this.oldColorLabelDisplay.Size = new System.Drawing.Size(116, 32);
            this.oldColorLabelDisplay.TabIndex = 0;
            // 
            // newColorLabelDisplay
            // 
            this.newColorLabelDisplay.Location = new System.Drawing.Point(302, 152);
            this.newColorLabelDisplay.MinimumSize = new System.Drawing.Size(116, 32);
            this.newColorLabelDisplay.Name = "newColorLabelDisplay";
            this.newColorLabelDisplay.Size = new System.Drawing.Size(116, 32);
            this.newColorLabelDisplay.TabIndex = 0;
            // 
            // ChangeColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(532, 369);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newColorBttn;
        private System.Windows.Forms.Button oldColorBttn;
        private System.Windows.Forms.Label oldColorLabelDisplay;
        private System.Windows.Forms.Label newColorLabelDisplay;
    }
}