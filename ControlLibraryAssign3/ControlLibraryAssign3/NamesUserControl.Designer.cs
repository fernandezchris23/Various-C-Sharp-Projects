namespace ControlLibraryAssign3
{
    partial class NamesUserControl
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
            this.membersNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupNameLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupNameLabel.Location = new System.Drawing.Point(0, 0);
            this.groupNameLabel.MaximumSize = new System.Drawing.Size(0, 50);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(295, 50);
            this.groupNameLabel.TabIndex = 0;
            this.groupNameLabel.Text = "Team 2: We\'re Okay";
            this.groupNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // membersNameLabel
            // 
            this.membersNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersNameLabel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.membersNameLabel.Location = new System.Drawing.Point(0, 50);
            this.membersNameLabel.Name = "membersNameLabel";
            this.membersNameLabel.Size = new System.Drawing.Size(295, 190);
            this.membersNameLabel.TabIndex = 0;
            this.membersNameLabel.Text = "Alejandro Barnola\nWalter Elwell\nChristopher Fernandez\nAlvaro Orozco\nKayla Ortiz\nV" +
    "anesa Perez";
            this.membersNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NamesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.membersNameLabel);
            this.Controls.Add(this.groupNameLabel);
            this.Name = "NamesUserControl";
            this.Size = new System.Drawing.Size(295, 240);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label membersNameLabel;
    }
}
