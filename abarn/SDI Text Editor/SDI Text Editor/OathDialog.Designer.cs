namespace SDI_Text_Editor
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
            this.oathUserControl = new ControlLibrary.OathUserControl();
            this.courseUserControl = new ControlLibraryAssign3.CourseUserControl();
            this.namesUserControl = new ControlLibraryAssign3.NamesUserControl();
            this.SuspendLayout();
            // 
            // oathUserControl
            // 
            this.oathUserControl.BackColor = System.Drawing.Color.Transparent;
            this.oathUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathUserControl.Location = new System.Drawing.Point(0, 77);
            this.oathUserControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oathUserControl.MinimumSize = new System.Drawing.Size(599, 52);
            this.oathUserControl.Name = "oathUserControl";
            this.oathUserControl.Size = new System.Drawing.Size(693, 91);
            this.oathUserControl.TabIndex = 2;
            // 
            // courseUserControl
            // 
            this.courseUserControl.BackColor = System.Drawing.Color.Transparent;
            this.courseUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseUserControl.Location = new System.Drawing.Point(0, 24);
            this.courseUserControl.MinimumSize = new System.Drawing.Size(612, 53);
            this.courseUserControl.Name = "courseUserControl";
            this.courseUserControl.Size = new System.Drawing.Size(693, 53);
            this.courseUserControl.TabIndex = 3;
            // 
            // namesUserControl
            // 
            this.namesUserControl.BackColor = System.Drawing.Color.LightGray;
            this.namesUserControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.namesUserControl.Location = new System.Drawing.Point(0, 168);
            this.namesUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namesUserControl.MinimumSize = new System.Drawing.Size(612, 74);
            this.namesUserControl.Name = "namesUserControl";
            this.namesUserControl.Size = new System.Drawing.Size(693, 74);
            this.namesUserControl.TabIndex = 4;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 242);
            this.Controls.Add(this.oathUserControl);
            this.Controls.Add(this.namesUserControl);
            this.Controls.Add(this.courseUserControl);
            this.MinimumSize = new System.Drawing.Size(630, 251);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.Controls.SetChildIndex(this.courseUserControl, 0);
            this.Controls.SetChildIndex(this.namesUserControl, 0);
            this.Controls.SetChildIndex(this.oathUserControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.OathUserControl oathUserControl;
        private ControlLibraryAssign3.CourseUserControl courseUserControl;
        private ControlLibraryAssign3.NamesUserControl namesUserControl;
    }
}