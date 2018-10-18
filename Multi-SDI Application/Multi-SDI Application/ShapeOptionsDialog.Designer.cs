namespace Multi_SDI_Application
{
    partial class ShapeOptionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeOptionsDialog));
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.xCoorBox = new System.Windows.Forms.TextBox();
            this.yCoorBox = new System.Windows.Forms.TextBox();
            this.penColorBttn = new System.Windows.Forms.Button();
            this.brushColorBttn = new System.Windows.Forms.Button();
            this.penTypeCombo = new System.Windows.Forms.ComboBox();
            this.shapeTypeCombo = new System.Windows.Forms.ComboBox();
            this.brushTypeCombo = new System.Windows.Forms.ComboBox();
            this.penColorLabel = new System.Windows.Forms.Label();
            this.brushColorLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.yCoorLabel = new System.Windows.Forms.Label();
            this.xCoorLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.locGroup = new System.Windows.Forms.GroupBox();
            this.colorGroup = new System.Windows.Forms.GroupBox();
            this.penTypeLabel = new System.Windows.Forms.Label();
            this.shapeTypeLabel = new System.Windows.Forms.Label();
            this.brushTypeLabel = new System.Windows.Forms.Label();
            this.currentShapeGroup = new System.Windows.Forms.GroupBox();
            this.currentShapeCombo = new System.Windows.Forms.ComboBox();
            this.sizeGroup.SuspendLayout();
            this.locGroup.SuspendLayout();
            this.colorGroup.SuspendLayout();
            this.currentShapeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(73, 35);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(104, 26);
            this.widthBox.TabIndex = 0;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(253, 35);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(104, 26);
            this.heightBox.TabIndex = 1;
            // 
            // xCoorBox
            // 
            this.xCoorBox.Location = new System.Drawing.Point(73, 91);
            this.xCoorBox.Name = "xCoorBox";
            this.xCoorBox.Size = new System.Drawing.Size(104, 26);
            this.xCoorBox.TabIndex = 2;
            // 
            // yCoorBox
            // 
            this.yCoorBox.Location = new System.Drawing.Point(253, 91);
            this.yCoorBox.Name = "yCoorBox";
            this.yCoorBox.Size = new System.Drawing.Size(104, 26);
            this.yCoorBox.TabIndex = 3;
            // 
            // penColorBttn
            // 
            this.penColorBttn.Location = new System.Drawing.Point(96, 33);
            this.penColorBttn.Name = "penColorBttn";
            this.penColorBttn.Size = new System.Drawing.Size(75, 23);
            this.penColorBttn.TabIndex = 4;
            this.penColorBttn.UseVisualStyleBackColor = true;
            this.penColorBttn.Click += new System.EventHandler(this.penColorBttn_Click);
            // 
            // brushColorBttn
            // 
            this.brushColorBttn.Location = new System.Drawing.Point(285, 34);
            this.brushColorBttn.Name = "brushColorBttn";
            this.brushColorBttn.Size = new System.Drawing.Size(75, 23);
            this.brushColorBttn.TabIndex = 5;
            this.brushColorBttn.UseVisualStyleBackColor = true;
            this.brushColorBttn.Click += new System.EventHandler(this.brushColorBttn_Click);
            // 
            // penTypeCombo
            // 
            this.penTypeCombo.FormattingEnabled = true;
            this.penTypeCombo.Location = new System.Drawing.Point(225, 336);
            this.penTypeCombo.Name = "penTypeCombo";
            this.penTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.penTypeCombo.TabIndex = 6;
            // 
            // shapeTypeCombo
            // 
            this.shapeTypeCombo.FormattingEnabled = true;
            this.shapeTypeCombo.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle",
            "Custom"});
            this.shapeTypeCombo.Location = new System.Drawing.Point(225, 401);
            this.shapeTypeCombo.Name = "shapeTypeCombo";
            this.shapeTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.shapeTypeCombo.TabIndex = 7;
            // 
            // brushTypeCombo
            // 
            this.brushTypeCombo.FormattingEnabled = true;
            this.brushTypeCombo.Items.AddRange(new object[] {
            "Linear Gradient",
            "Solid",
            "Hatched"});
            this.brushTypeCombo.Location = new System.Drawing.Point(225, 369);
            this.brushTypeCombo.Name = "brushTypeCombo";
            this.brushTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.brushTypeCombo.TabIndex = 8;
            // 
            // penColorLabel
            // 
            this.penColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penColorLabel.AutoSize = true;
            this.penColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penColorLabel.Location = new System.Drawing.Point(12, 34);
            this.penColorLabel.Name = "penColorLabel";
            this.penColorLabel.Size = new System.Drawing.Size(82, 20);
            this.penColorLabel.TabIndex = 10;
            this.penColorLabel.Text = "Pen Color:";
            // 
            // brushColorLabel
            // 
            this.brushColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brushColorLabel.AutoSize = true;
            this.brushColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brushColorLabel.Location = new System.Drawing.Point(186, 35);
            this.brushColorLabel.Name = "brushColorLabel";
            this.brushColorLabel.Size = new System.Drawing.Size(96, 20);
            this.brushColorLabel.TabIndex = 11;
            this.brushColorLabel.Text = "Brush Color:";
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(3, 27);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(376, 48);
            this.locationLabel.TabIndex = 12;
            this.locationLabel.Text = "Coordinates below signify the top left corner of the\r\nshape (or the top left corn" +
    "er of an invisible bounding\r\nbox around the shape if not a rectangle)";
            // 
            // yCoorLabel
            // 
            this.yCoorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yCoorLabel.AutoSize = true;
            this.yCoorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCoorLabel.Location = new System.Drawing.Point(226, 94);
            this.yCoorLabel.Name = "yCoorLabel";
            this.yCoorLabel.Size = new System.Drawing.Size(24, 20);
            this.yCoorLabel.TabIndex = 13;
            this.yCoorLabel.Text = "Y:";
            // 
            // xCoorLabel
            // 
            this.xCoorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xCoorLabel.AutoSize = true;
            this.xCoorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCoorLabel.Location = new System.Drawing.Point(43, 94);
            this.xCoorLabel.Name = "xCoorLabel";
            this.xCoorLabel.Size = new System.Drawing.Size(24, 20);
            this.xCoorLabel.TabIndex = 14;
            this.xCoorLabel.Text = "X:";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(189, 38);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(60, 20);
            this.heightLabel.TabIndex = 15;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(18, 38);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(54, 20);
            this.widthLabel.TabIndex = 16;
            this.widthLabel.Text = "Width:";
            // 
            // sizeGroup
            // 
            this.sizeGroup.BackColor = System.Drawing.Color.Transparent;
            this.sizeGroup.Controls.Add(this.widthLabel);
            this.sizeGroup.Controls.Add(this.widthBox);
            this.sizeGroup.Controls.Add(this.heightLabel);
            this.sizeGroup.Controls.Add(this.heightBox);
            this.sizeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGroup.Location = new System.Drawing.Point(47, 12);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(380, 86);
            this.sizeGroup.TabIndex = 17;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Shape Size";
            // 
            // locGroup
            // 
            this.locGroup.BackColor = System.Drawing.Color.Transparent;
            this.locGroup.Controls.Add(this.xCoorBox);
            this.locGroup.Controls.Add(this.yCoorBox);
            this.locGroup.Controls.Add(this.locationLabel);
            this.locGroup.Controls.Add(this.yCoorLabel);
            this.locGroup.Controls.Add(this.xCoorLabel);
            this.locGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locGroup.Location = new System.Drawing.Point(47, 102);
            this.locGroup.Name = "locGroup";
            this.locGroup.Size = new System.Drawing.Size(380, 141);
            this.locGroup.TabIndex = 18;
            this.locGroup.TabStop = false;
            this.locGroup.Text = "Location";
            // 
            // colorGroup
            // 
            this.colorGroup.BackColor = System.Drawing.Color.Transparent;
            this.colorGroup.Controls.Add(this.penColorBttn);
            this.colorGroup.Controls.Add(this.brushColorBttn);
            this.colorGroup.Controls.Add(this.penColorLabel);
            this.colorGroup.Controls.Add(this.brushColorLabel);
            this.colorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGroup.Location = new System.Drawing.Point(47, 245);
            this.colorGroup.Name = "colorGroup";
            this.colorGroup.Size = new System.Drawing.Size(380, 76);
            this.colorGroup.TabIndex = 19;
            this.colorGroup.TabStop = false;
            this.colorGroup.Text = "Colors";
            // 
            // penTypeLabel
            // 
            this.penTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penTypeLabel.AutoSize = true;
            this.penTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.penTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penTypeLabel.Location = new System.Drawing.Point(140, 335);
            this.penTypeLabel.Name = "penTypeLabel";
            this.penTypeLabel.Size = new System.Drawing.Size(79, 20);
            this.penTypeLabel.TabIndex = 12;
            this.penTypeLabel.Text = "Pen Type:";
            // 
            // shapeTypeLabel
            // 
            this.shapeTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeTypeLabel.AutoSize = true;
            this.shapeTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.shapeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeTypeLabel.Location = new System.Drawing.Point(121, 401);
            this.shapeTypeLabel.Name = "shapeTypeLabel";
            this.shapeTypeLabel.Size = new System.Drawing.Size(98, 20);
            this.shapeTypeLabel.TabIndex = 20;
            this.shapeTypeLabel.Text = "Shape Type:";
            // 
            // brushTypeLabel
            // 
            this.brushTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brushTypeLabel.AutoSize = true;
            this.brushTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.brushTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brushTypeLabel.Location = new System.Drawing.Point(126, 368);
            this.brushTypeLabel.Name = "brushTypeLabel";
            this.brushTypeLabel.Size = new System.Drawing.Size(93, 20);
            this.brushTypeLabel.TabIndex = 21;
            this.brushTypeLabel.Text = "Brush Type:";
            // 
            // currentShapeGroup
            // 
            this.currentShapeGroup.BackColor = System.Drawing.Color.Transparent;
            this.currentShapeGroup.Controls.Add(this.currentShapeCombo);
            this.currentShapeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentShapeGroup.Location = new System.Drawing.Point(47, 440);
            this.currentShapeGroup.Name = "currentShapeGroup";
            this.currentShapeGroup.Size = new System.Drawing.Size(380, 60);
            this.currentShapeGroup.TabIndex = 22;
            this.currentShapeGroup.TabStop = false;
            this.currentShapeGroup.Text = "Current Shape";
            // 
            // currentShapeCombo
            // 
            this.currentShapeCombo.FormattingEnabled = true;
            this.currentShapeCombo.Location = new System.Drawing.Point(44, 25);
            this.currentShapeCombo.Name = "currentShapeCombo";
            this.currentShapeCombo.Size = new System.Drawing.Size(279, 28);
            this.currentShapeCombo.TabIndex = 0;
            this.currentShapeCombo.SelectedIndexChanged += new System.EventHandler(this.currentShapeCombo_SelectedIndexChanged);
            // 
            // ShapeOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 521);
            this.Controls.Add(this.currentShapeGroup);
            this.Controls.Add(this.brushTypeLabel);
            this.Controls.Add(this.shapeTypeLabel);
            this.Controls.Add(this.penTypeLabel);
            this.Controls.Add(this.colorGroup);
            this.Controls.Add(this.locGroup);
            this.Controls.Add(this.sizeGroup);
            this.Controls.Add(this.brushTypeCombo);
            this.Controls.Add(this.shapeTypeCombo);
            this.Controls.Add(this.penTypeCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapeOptionsDialog";
            this.ShowIcon = false;
            this.Text = "Shape Options";
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            this.locGroup.ResumeLayout(false);
            this.locGroup.PerformLayout();
            this.colorGroup.ResumeLayout(false);
            this.colorGroup.PerformLayout();
            this.currentShapeGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox xCoorBox;
        private System.Windows.Forms.TextBox yCoorBox;
        private System.Windows.Forms.Button penColorBttn;
        private System.Windows.Forms.Button brushColorBttn;
        private System.Windows.Forms.ComboBox penTypeCombo;
        private System.Windows.Forms.ComboBox shapeTypeCombo;
        private System.Windows.Forms.ComboBox brushTypeCombo;
        private System.Windows.Forms.Label penColorLabel;
        private System.Windows.Forms.Label brushColorLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label yCoorLabel;
        private System.Windows.Forms.Label xCoorLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.GroupBox locGroup;
        private System.Windows.Forms.GroupBox colorGroup;
        private System.Windows.Forms.Label penTypeLabel;
        private System.Windows.Forms.Label shapeTypeLabel;
        private System.Windows.Forms.Label brushTypeLabel;
        private System.Windows.Forms.GroupBox currentShapeGroup;
        private System.Windows.Forms.ComboBox currentShapeCombo;
    }
}