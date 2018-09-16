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
            this.membersNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // membersNameLabel
            // 
            this.membersNameLabel.BackColor = System.Drawing.Color.LightCyan;
            this.membersNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersNameLabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.membersNameLabel.Location = new System.Drawing.Point(0, 0);
            this.membersNameLabel.Name = "membersNameLabel";
            this.membersNameLabel.Size = new System.Drawing.Size(843, 48);
            this.membersNameLabel.TabIndex = 0;
            this.membersNameLabel.Text = "We\'re Okay:\nAlejandro Barnola, Walter Elwell, Christopher Fernandez, Alvaro Orozc" +
    "o, Kayla Ortiz, and Vanesa Perez";
            this.membersNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NamesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.membersNameLabel);
            this.Name = "NamesUserControl";
            this.Size = new System.Drawing.Size(843, 48);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label membersNameLabel;
    }
}
