﻿namespace ControlLibrary
{
    partial class oathControl
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
            this.OathLabel.BackColor = System.Drawing.Color.Transparent;
            this.OathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OathLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OathLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OathLabel.Location = new System.Drawing.Point(0, 0);
            this.OathLabel.Name = "OathLabel";
            this.OathLabel.Size = new System.Drawing.Size(442, 172);
            this.OathLabel.TabIndex = 1;
            this.OathLabel.Text = "I understand that this is a group project.\r\n\r\nIt is in my best interest to partic" +
    "ipate in writing the homework and study all the code from the homework.\r\n";
            this.OathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oathControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.OathLabel);
            this.Name = "oathControl";
            this.Size = new System.Drawing.Size(442, 172);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OathLabel;
    }
}
