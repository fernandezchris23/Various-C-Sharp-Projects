namespace TextThreadProgram
{
    partial class OathDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OathDialog));
            this.oathControl1 = new ControlLibrary.oathControl();
            this.groupMembers1 = new ControlLibrary.groupMembers();
            this.courseControl1 = new ControlLibrary.courseControl();
            this.SuspendLayout();
            // 
            // oathControl1
            // 
            this.oathControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathControl1.Location = new System.Drawing.Point(8, 98);
            this.oathControl1.Name = "oathControl1";
            this.oathControl1.Size = new System.Drawing.Size(325, 164);
            this.oathControl1.TabIndex = 2;
            // 
            // groupMembers1
            // 
            this.groupMembers1.BackColor = System.Drawing.Color.Transparent;
            this.groupMembers1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupMembers1.Location = new System.Drawing.Point(0, 308);
            this.groupMembers1.Margin = new System.Windows.Forms.Padding(4);
            this.groupMembers1.Name = "groupMembers1";
            this.groupMembers1.Size = new System.Drawing.Size(592, 58);
            this.groupMembers1.TabIndex = 1;
            // 
            // courseControl1
            // 
            this.courseControl1.BackColor = System.Drawing.Color.Transparent;
            this.courseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl1.Location = new System.Drawing.Point(0, 0);
            this.courseControl1.Name = "courseControl1";
            this.courseControl1.Size = new System.Drawing.Size(592, 54);
            this.courseControl1.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.oathControl1);
            this.Controls.Add(this.groupMembers1);
            this.Controls.Add(this.courseControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.Text = "Oath";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.courseControl courseControl1;
        private ControlLibrary.groupMembers groupMembers1;
        private ControlLibrary.oathControl oathControl1;
    }
}