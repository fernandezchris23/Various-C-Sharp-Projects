namespace ControlLibrary
{
    partial class BaseDialogForm
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
            this.groupMembers1 = new ControlLibrary.groupMembers();
            this.courseControl1 = new ControlLibrary.courseControl();
            this.SuspendLayout();
            // 
            // groupMembers1
            // 
            this.groupMembers1.BackColor = System.Drawing.Color.Transparent;
            this.groupMembers1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupMembers1.Location = new System.Drawing.Point(0, 444);
            this.groupMembers1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupMembers1.Name = "groupMembers1";
            this.groupMembers1.Size = new System.Drawing.Size(888, 94);
            this.groupMembers1.TabIndex = 0;
            // 
            // courseControl1
            // 
            this.courseControl1.BackColor = System.Drawing.Color.Transparent;
            this.courseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl1.Location = new System.Drawing.Point(0, 0);
            this.courseControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseControl1.Name = "courseControl1";
            this.courseControl1.Size = new System.Drawing.Size(888, 66);
            this.courseControl1.TabIndex = 1;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 538);
            this.Controls.Add(this.courseControl1);
            this.Controls.Add(this.groupMembers1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private groupMembers groupMembers1;
        private courseControl courseControl1;
    }
}