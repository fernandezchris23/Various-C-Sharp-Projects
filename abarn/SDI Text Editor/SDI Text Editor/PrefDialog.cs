using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibraryAssign3;

namespace SDI_Text_Editor
{
    public partial class PrefDialog : DialogBaseForm
    {   
        private int RectHeight;
        private int EllipWidth;
        private float Ratio;
        private Button okayButton;
        private Button cancelButton;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button changeFontButton;
        private MainForm mainForm;
        
        public PrefDialog()
        {
            
        }

        public PrefDialog(MainForm mainForm)
        {
            
        }

        private void PrefDialog_Load(object sender, EventArgs e)
        {
        }        

        private void okayButton_Click(object sender, EventArgs e)
        {            
            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
                        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.changeFontButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.dialogBaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogBaseFormPanel
            // 
            this.dialogBaseFormPanel.Controls.Add(this.okayButton);
            this.dialogBaseFormPanel.Controls.Add(this.cancelButton);
            this.dialogBaseFormPanel.Controls.Add(this.textBox2);
            this.dialogBaseFormPanel.Controls.Add(this.textBox1);
            this.dialogBaseFormPanel.Controls.Add(this.label1);
            this.dialogBaseFormPanel.Controls.Add(this.button2);
            this.dialogBaseFormPanel.Controls.Add(this.changeFontButton);
            this.dialogBaseFormPanel.Size = new System.Drawing.Size(480, 318);
            // 
            // changeFontButton
            // 
            this.changeFontButton.Location = new System.Drawing.Point(324, 26);
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.Size = new System.Drawing.Size(75, 23);
            this.changeFontButton.TabIndex = 0;
            this.changeFontButton.Text = "Change...";
            this.changeFontButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(263, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 35);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(73, 194);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 35);
            this.okayButton.TabIndex = 6;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            // 
            // PrefDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(480, 435);
            this.Name = "PrefDialog";
            this.dialogBaseFormPanel.ResumeLayout(false);
            this.dialogBaseFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
