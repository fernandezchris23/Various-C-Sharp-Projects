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
            System.Windows.Forms.Label membersNameLabel;
            membersNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // membersNameLabel
            // 
            membersNameLabel.BackColor = System.Drawing.Color.LightCyan;
            membersNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            membersNameLabel.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold);
            membersNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            membersNameLabel.Location = new System.Drawing.Point(0, 0);
            membersNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            membersNameLabel.Name = "membersNameLabel";
            membersNameLabel.Size = new System.Drawing.Size(632, 50);
            membersNameLabel.TabIndex = 0;
            membersNameLabel.Text = "We\'re Okay:\nAlejandro Barnola, Walter Elwell, Christopher Fernandez, Alvaro Orozc" +
    "o, Kayla Ortiz, and Vanesa Perez";
            membersNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            membersNameLabel.Click += new System.EventHandler(this.membersNameLabel_Click);
            // 
            // NamesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(membersNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NamesUserControl";
            this.Size = new System.Drawing.Size(632, 50);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
