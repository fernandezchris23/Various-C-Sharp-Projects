namespace TextThreadProgram
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.groupMembers1 = new ControlLibrary.groupMembers();
            this.courseControl1 = new ControlLibrary.courseControl();
            this.aboutControl1 = new ControlLibrary.aboutControl();
            this.SuspendLayout();
            // 
            // groupMembers1
            // 
            this.groupMembers1.BackColor = System.Drawing.Color.Transparent;
            this.groupMembers1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupMembers1.Location = new System.Drawing.Point(0, 355);
            this.groupMembers1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupMembers1.Name = "groupMembers1";
            this.groupMembers1.Size = new System.Drawing.Size(678, 74);
            this.groupMembers1.TabIndex = 3;
            // 
            // courseControl1
            // 
            this.courseControl1.BackColor = System.Drawing.Color.Transparent;
            this.courseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl1.Location = new System.Drawing.Point(0, 0);
            this.courseControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.courseControl1.Name = "courseControl1";
            this.courseControl1.Size = new System.Drawing.Size(678, 66);
            this.courseControl1.TabIndex = 2;
            // 
            // aboutControl1
            // 
            this.aboutControl1.BackColor = System.Drawing.Color.Transparent;
            this.aboutControl1.Location = new System.Drawing.Point(0, 95);
            this.aboutControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(368, 158);
            this.aboutControl1.TabIndex = 4;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 429);
            this.Controls.Add(this.aboutControl1);
            this.Controls.Add(this.groupMembers1);
            this.Controls.Add(this.courseControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.groupMembers groupMembers1;
        private ControlLibrary.courseControl courseControl1;
        private ControlLibrary.aboutControl aboutControl1;
    }
}