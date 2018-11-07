namespace Assign2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.sttgsBox = new System.Windows.Forms.GroupBox();
            this.saveLocBttn = new System.Windows.Forms.Button();
            this.saveSizeBttn = new System.Windows.Forms.Button();
            this.resetSettBttn = new System.Windows.Forms.Button();
            this.addNameBttn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sttgsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sttgsBox
            // 
            this.sttgsBox.Controls.Add(this.saveLocBttn);
            this.sttgsBox.Controls.Add(this.saveSizeBttn);
            this.sttgsBox.Controls.Add(this.resetSettBttn);
            this.sttgsBox.Controls.Add(this.addNameBttn);
            this.sttgsBox.Controls.Add(this.nameBox);
            this.sttgsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sttgsBox.Location = new System.Drawing.Point(0, 0);
            this.sttgsBox.Name = "sttgsBox";
            this.sttgsBox.Size = new System.Drawing.Size(625, 114);
            this.sttgsBox.TabIndex = 0;
            this.sttgsBox.TabStop = false;
            this.sttgsBox.Text = "groupBox1";
            // 
            // saveLocBttn
            // 
            this.saveLocBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveLocBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocBttn.Location = new System.Drawing.Point(515, 82);
            this.saveLocBttn.Name = "saveLocBttn";
            this.saveLocBttn.Size = new System.Drawing.Size(98, 23);
            this.saveLocBttn.TabIndex = 8;
            this.saveLocBttn.Text = "Save Location";
            this.saveLocBttn.UseVisualStyleBackColor = true;
            this.saveLocBttn.Click += new System.EventHandler(this.saveLocBttn_Click);
            // 
            // saveSizeBttn
            // 
            this.saveSizeBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveSizeBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSizeBttn.Location = new System.Drawing.Point(12, 82);
            this.saveSizeBttn.Name = "saveSizeBttn";
            this.saveSizeBttn.Size = new System.Drawing.Size(83, 23);
            this.saveSizeBttn.TabIndex = 7;
            this.saveSizeBttn.Text = "Save Size";
            this.saveSizeBttn.UseVisualStyleBackColor = true;
            this.saveSizeBttn.Click += new System.EventHandler(this.saveSizeBttn_Click);
            // 
            // resetSettBttn
            // 
            this.resetSettBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetSettBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetSettBttn.Location = new System.Drawing.Point(280, 82);
            this.resetSettBttn.Name = "resetSettBttn";
            this.resetSettBttn.Size = new System.Drawing.Size(102, 23);
            this.resetSettBttn.TabIndex = 6;
            this.resetSettBttn.Text = "Reset Settings";
            this.resetSettBttn.UseVisualStyleBackColor = true;
            this.resetSettBttn.Click += new System.EventHandler(this.resetSettBttn_Click);
            // 
            // addNameBttn
            // 
            this.addNameBttn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addNameBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNameBttn.Location = new System.Drawing.Point(423, 28);
            this.addNameBttn.Name = "addNameBttn";
            this.addNameBttn.Size = new System.Drawing.Size(83, 23);
            this.addNameBttn.TabIndex = 5;
            this.addNameBttn.Text = "Add Name";
            this.addNameBttn.UseVisualStyleBackColor = true;
            this.addNameBttn.Click += new System.EventHandler(this.addNameBttn_Click_1);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameBox.Location = new System.Drawing.Point(68, 28);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(336, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 428);
            this.Controls.Add(this.sttgsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sttgsBox.ResumeLayout(false);
            this.sttgsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sttgsBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button saveLocBttn;
        private System.Windows.Forms.Button saveSizeBttn;
        private System.Windows.Forms.Button resetSettBttn;
        private System.Windows.Forms.Button addNameBttn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

