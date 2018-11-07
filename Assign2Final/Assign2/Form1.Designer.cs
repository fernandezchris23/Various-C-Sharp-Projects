namespace Assign2
{
    partial class UserSettings
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sttgsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sttgsBox
            // 
            this.sttgsBox.BackColor = System.Drawing.Color.DarkBlue;
            this.sttgsBox.Controls.Add(this.saveLocBttn);
            this.sttgsBox.Controls.Add(this.saveSizeBttn);
            this.sttgsBox.Controls.Add(this.resetSettBttn);
            this.sttgsBox.Controls.Add(this.addNameBttn);
            this.sttgsBox.Controls.Add(this.nameBox);
            this.sttgsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sttgsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sttgsBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sttgsBox.Location = new System.Drawing.Point(0, 0);
            this.sttgsBox.Margin = new System.Windows.Forms.Padding(4);
            this.sttgsBox.Name = "sttgsBox";
            this.sttgsBox.Padding = new System.Windows.Forms.Padding(4);
            this.sttgsBox.Size = new System.Drawing.Size(833, 140);
            this.sttgsBox.TabIndex = 0;
            this.sttgsBox.TabStop = false;
            this.sttgsBox.Text = "Enter A Valid Name:";
            // 
            // saveLocBttn
            // 
            this.saveLocBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveLocBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveLocBttn.Location = new System.Drawing.Point(687, 101);
            this.saveLocBttn.Margin = new System.Windows.Forms.Padding(4);
            this.saveLocBttn.Name = "saveLocBttn";
            this.saveLocBttn.Size = new System.Drawing.Size(131, 28);
            this.saveLocBttn.TabIndex = 8;
            this.saveLocBttn.Text = "Save Location";
            this.saveLocBttn.UseVisualStyleBackColor = true;
            this.saveLocBttn.Click += new System.EventHandler(this.saveLocBttn_Click);
            // 
            // saveSizeBttn
            // 
            this.saveSizeBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveSizeBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSizeBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveSizeBttn.Location = new System.Drawing.Point(16, 101);
            this.saveSizeBttn.Margin = new System.Windows.Forms.Padding(4);
            this.saveSizeBttn.Name = "saveSizeBttn";
            this.saveSizeBttn.Size = new System.Drawing.Size(111, 28);
            this.saveSizeBttn.TabIndex = 7;
            this.saveSizeBttn.Text = "Save Size";
            this.saveSizeBttn.UseVisualStyleBackColor = true;
            this.saveSizeBttn.Click += new System.EventHandler(this.saveSizeBttn_Click);
            // 
            // resetSettBttn
            // 
            this.resetSettBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetSettBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetSettBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetSettBttn.Location = new System.Drawing.Point(373, 101);
            this.resetSettBttn.Margin = new System.Windows.Forms.Padding(4);
            this.resetSettBttn.Name = "resetSettBttn";
            this.resetSettBttn.Size = new System.Drawing.Size(136, 28);
            this.resetSettBttn.TabIndex = 6;
            this.resetSettBttn.Text = "Reset Settings";
            this.resetSettBttn.UseVisualStyleBackColor = true;
            this.resetSettBttn.Click += new System.EventHandler(this.resetSettBttn_Click);
            // 
            // addNameBttn
            // 
            this.addNameBttn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addNameBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNameBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNameBttn.Location = new System.Drawing.Point(564, 34);
            this.addNameBttn.Margin = new System.Windows.Forms.Padding(4);
            this.addNameBttn.Name = "addNameBttn";
            this.addNameBttn.Size = new System.Drawing.Size(111, 28);
            this.addNameBttn.TabIndex = 5;
            this.addNameBttn.Text = "Add Name";
            this.addNameBttn.UseVisualStyleBackColor = true;
            this.addNameBttn.Click += new System.EventHandler(this.addNameBttn_Click_1);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameBox.Location = new System.Drawing.Point(91, 34);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(447, 26);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Location = new System.Drawing.Point(0, 140);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(833, 387);
            this.listView1.TabIndex = 1;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 527);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sttgsBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserSettings";
            this.Text = "User Settings";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

