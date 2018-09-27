namespace SDI_Text_Editor
{
    partial class CourseUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseNameLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.courseNameLabel.Location = new System.Drawing.Point(0, 0);
            this.courseNameLabel.MinimumSize = new System.Drawing.Size(0, 30);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(303, 30);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Advanced Windows Programming";
            this.courseNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // semesterLabel
            // 
            this.semesterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semesterLabel.Font = new System.Drawing.Font("Cambria", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.semesterLabel.Location = new System.Drawing.Point(0, 30);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(303, 23);
            this.semesterLabel.TabIndex = 0;
            this.semesterLabel.Text = "Fall 2018";
            this.semesterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CourseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Name = "CourseUserControl";
            this.Size = new System.Drawing.Size(303, 53);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label semesterLabel;
    }
}
