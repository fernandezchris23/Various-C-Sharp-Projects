namespace ControlLibrary
{
    partial class courseControl
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
            this.courseInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseInfo
            // 
            this.courseInfo.BackColor = System.Drawing.Color.Transparent;
            this.courseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseInfo.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.courseInfo.Location = new System.Drawing.Point(0, 0);
            this.courseInfo.Name = "courseInfo";
            this.courseInfo.Size = new System.Drawing.Size(366, 50);
            this.courseInfo.TabIndex = 0;
            this.courseInfo.Text = "Advanced Windows Programming\r\nFall 2018";
            this.courseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.courseInfo);
            this.Name = "courseControl";
            this.Size = new System.Drawing.Size(366, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label courseInfo;
    }
}
