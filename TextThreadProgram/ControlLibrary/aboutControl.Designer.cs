namespace ControlLibrary
{
    partial class aboutControl
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
            this.OathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OathLabel
            // 
            this.OathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OathLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OathLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OathLabel.Location = new System.Drawing.Point(0, 0);
            this.OathLabel.Name = "OathLabel";
            this.OathLabel.Size = new System.Drawing.Size(401, 128);
            this.OathLabel.TabIndex = 1;
            this.OathLabel.Text = "This assignment is to create a text\r\ndrawing multi-document application.\r\n";
            this.OathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.OathLabel);
            this.Name = "aboutControl";
            this.Size = new System.Drawing.Size(401, 128);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OathLabel;
    }
}
