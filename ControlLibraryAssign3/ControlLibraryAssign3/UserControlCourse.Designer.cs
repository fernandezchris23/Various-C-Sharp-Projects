namespace ControlLibraryAssign3
{
    partial class UserControlCourse
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
            this.semestorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseNameLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.courseNameLabel.Location = new System.Drawing.Point(0, 0);
            this.courseNameLabel.MinimumSize = new System.Drawing.Size(0, 25);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(254, 25);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Advanced Windows Programming";
            this.courseNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // semestorLabel
            // 
            this.semestorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semestorLabel.Font = new System.Drawing.Font("Cambria", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestorLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.semestorLabel.Location = new System.Drawing.Point(0, 25);
            this.semestorLabel.Name = "semestorLabel";
            this.semestorLabel.Size = new System.Drawing.Size(254, 24);
            this.semestorLabel.TabIndex = 0;
            this.semestorLabel.Text = "Fall 2018";
            this.semestorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserControlCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.semestorLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Name = "UserControlCourse";
            this.Size = new System.Drawing.Size(254, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label semestorLabel;
    }
}
