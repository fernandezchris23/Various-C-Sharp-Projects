namespace ControlLibrary
{
    partial class groupMembers
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
            System.Windows.Forms.Label membersNameLabel;
            membersNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // membersNameLabel
            // 
            membersNameLabel.BackColor = System.Drawing.Color.Transparent;
            membersNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            membersNameLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            membersNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            membersNameLabel.Location = new System.Drawing.Point(0, 0);
            membersNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            membersNameLabel.Name = "membersNameLabel";
            membersNameLabel.Size = new System.Drawing.Size(476, 76);
            membersNameLabel.TabIndex = 1;
            membersNameLabel.Text = "We\'re (Not) Okay:\r\nAlejandro Barnola, Christopher Fernandez, Alvaro Orozco, and V" +
    "anesa Perez";
            membersNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(membersNameLabel);
            this.Name = "groupMembers";
            this.Size = new System.Drawing.Size(476, 76);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
