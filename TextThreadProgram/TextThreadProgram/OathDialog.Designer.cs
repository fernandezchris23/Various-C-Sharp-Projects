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
            this.SuspendLayout();
            // 
            // oathControl1
            // 
            this.oathControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathControl1.ForeColor = System.Drawing.Color.White;
            this.oathControl1.Location = new System.Drawing.Point(0, 112);
            this.oathControl1.Margin = new System.Windows.Forms.Padding(5);
            this.oathControl1.Name = "oathControl1";
            this.oathControl1.Size = new System.Drawing.Size(364, 177);
            this.oathControl1.TabIndex = 2;
            this.oathControl1.Load += new System.EventHandler(this.oathControl1_Load);
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(679, 430);
            this.Controls.Add(this.oathControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.Text = "Oath";
            this.ResumeLayout(false);

        }

        #endregion
        private ControlLibrary.oathControl oathControl1;
    }
}