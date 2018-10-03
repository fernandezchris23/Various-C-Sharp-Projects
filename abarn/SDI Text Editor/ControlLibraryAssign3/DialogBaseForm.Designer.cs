namespace ControlLibraryAssign3
{
    partial class DialogBaseForm
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
            this.dialogBaseFormPanel = new System.Windows.Forms.Panel();
            this.courseUserControl = new ControlLibraryAssign3.CourseUserControl();
            this.namesUserControl1 = new ControlLibraryAssign3.NamesUserControl();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.dialogBaseFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogBaseFormPanel.Location = new System.Drawing.Point(0, 53);
            this.dialogBaseFormPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dialogBaseFormPanel.Name = "dialogBaseFormPanel";
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(1115, 331);
            this.dialogBaseFormPanel.TabIndex = 2;
            // 
            // courseUserControl
            // 
            this.courseUserControl.BackColor = System.Drawing.Color.Transparent;
            this.courseUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseUserControl.Location = new System.Drawing.Point(0, 0);
            this.courseUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseUserControl.Name = "courseUserControl";
            this.courseUserControl.Size = new System.Drawing.Size(1115, 53);
            this.courseUserControl.TabIndex = 1;
            // 
            // namesUserControl1
            // 
            this.namesUserControl1.BackColor = System.Drawing.Color.LightGray;
            this.namesUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.namesUserControl1.Location = new System.Drawing.Point(0, 384);
            this.namesUserControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namesUserControl1.Name = "namesUserControl1";
            this.namesUserControl1.Size = new System.Drawing.Size(1115, 64);
            this.namesUserControl1.TabIndex = 0;
            // 
            // DialogBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 448);
            this.Controls.Add(this.dialogBaseFormPanel);
            this.Controls.Add(this.courseUserControl);
            this.Controls.Add(this.namesUserControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DialogBaseForm";
            this.Text = "DialogBaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private NamesUserControl namesUserControl1;
        private CourseUserControl courseUserControl;
        protected internal System.Windows.Forms.Panel dialogBaseFormPanel;
    }
}