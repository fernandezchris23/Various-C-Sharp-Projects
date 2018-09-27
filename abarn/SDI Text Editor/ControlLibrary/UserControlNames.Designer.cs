namespace SDI_Text_Editor
{
    partial class UserControlNames
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
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.memberNames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupNameLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupNameLabel.Location = new System.Drawing.Point(0, 0);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(213, 50);
            this.groupNameLabel.TabIndex = 0;
            this.groupNameLabel.Text = "Team 2: We\'re Okay";
            this.groupNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberNames
            // 
            this.memberNames.BackColor = System.Drawing.Color.Transparent;
            this.memberNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberNames.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNames.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.memberNames.Location = new System.Drawing.Point(0, 50);
            this.memberNames.Name = "memberNames";
            this.memberNames.Size = new System.Drawing.Size(213, 117);
            this.memberNames.TabIndex = 0;
            this.memberNames.Text = "Alejandro Barnola\nWalter Elwell\nChristopher Fernandez\nAlvaro Orozco\nKayla Ortiz\nV" +
    "anesa Perez";
            // 
            // UserControlNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.memberNames);
            this.Controls.Add(this.groupNameLabel);
            this.Name = "UserControlNames";
            this.Size = new System.Drawing.Size(213, 167);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label memberNames;
    }
}
