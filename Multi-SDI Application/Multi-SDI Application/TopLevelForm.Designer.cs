namespace Multi_SDI_Application
{
    partial class TopLevelForm
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripShapes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelPlus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelMinus = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelColors = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStyle = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.oathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newWinToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ellipiseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.solidPenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customDashedPenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CompoundToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.solidBrushToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.hatchBrushToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.linearGradientToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.penColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.brushColortoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripShapes.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // contextMenuStripShapes
            // 
            this.contextMenuStripShapes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripShapes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapeToolStripMenuItem,
            this.penToolStripMenuItem,
            this.brushToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.contextMenuStripShapes.Name = "contextMenuStripShapes";
            this.contextMenuStripShapes.Size = new System.Drawing.Size(120, 100);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.lineToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.lineToolStripMenuItem.Text = "Custom";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.customDashedToolStripMenuItem,
            this.compoundToolStripMenuItem});
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.penToolStripMenuItem.Text = "Pen";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // customDashedToolStripMenuItem
            // 
            this.customDashedToolStripMenuItem.Name = "customDashedToolStripMenuItem";
            this.customDashedToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.customDashedToolStripMenuItem.Text = "Custom Dashed";
            this.customDashedToolStripMenuItem.Click += new System.EventHandler(this.customDashedToolStripMenuItem_Click);
            // 
            // compoundToolStripMenuItem
            // 
            this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
            this.compoundToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.compoundToolStripMenuItem.Text = "Compound";
            this.compoundToolStripMenuItem.Click += new System.EventHandler(this.compoundToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBrushToolStripMenuItem,
            this.hatchToolStripMenuItem,
            this.linearGradientToolStripMenuItem});
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // solidBrushToolStripMenuItem
            // 
            this.solidBrushToolStripMenuItem.Name = "solidBrushToolStripMenuItem";
            this.solidBrushToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.solidBrushToolStripMenuItem.Text = "Solid";
            this.solidBrushToolStripMenuItem.Click += new System.EventHandler(this.solidBrushToolStripMenuItem_Click);
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.hatchToolStripMenuItem.Text = "Hatch";
            this.hatchToolStripMenuItem.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
            // 
            // linearGradientToolStripMenuItem
            // 
            this.linearGradientToolStripMenuItem.Name = "linearGradientToolStripMenuItem";
            this.linearGradientToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.linearGradientToolStripMenuItem.Text = "Linear gradient";
            this.linearGradientToolStripMenuItem.Click += new System.EventHandler(this.linearGradientToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penColorToolStripMenuItem,
            this.brushColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // penColorToolStripMenuItem
            // 
            this.penColorToolStripMenuItem.Name = "penColorToolStripMenuItem";
            this.penColorToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.penColorToolStripMenuItem.Text = "Pen color";
            this.penColorToolStripMenuItem.Click += new System.EventHandler(this.penColorToolStripMenuItem_Click);
            // 
            // brushColorToolStripMenuItem
            // 
            this.brushColorToolStripMenuItem.Name = "brushColorToolStripMenuItem";
            this.brushColorToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.brushColorToolStripMenuItem.Text = "Brush color";
            this.brushColorToolStripMenuItem.Click += new System.EventHandler(this.brushColorToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelPlus,
            this.toolStripLabelMinus,
            this.saveToolStripButton,
            this.openToolStripButton,
            this.oathToolStripButton,
            this.aboutToolStripButton,
            this.newWinToolStripButton,
            this.ellipiseToolStripButton,
            this.rectToolStripButton,
            this.customToolStripButton,
            this.solidPenToolStripButton,
            this.customDashedPenToolStripButton,
            this.CompoundToolStripButton,
            this.solidBrushToolStripButton,
            this.hatchBrushToolStripButton,
            this.linearGradientToolStripButton,
            this.penColorToolStripButton,
            this.brushColortoolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.MinimumSize = new System.Drawing.Size(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabelPlus
            // 
            this.toolStripLabelPlus.Name = "toolStripLabelPlus";
            this.toolStripLabelPlus.Size = new System.Drawing.Size(19, 24);
            this.toolStripLabelPlus.Text = "+";
            this.toolStripLabelPlus.Click += new System.EventHandler(this.toolStripLabelPlus_Click);
            // 
            // toolStripLabelMinus
            // 
            this.toolStripLabelMinus.Name = "toolStripLabelMinus";
            this.toolStripLabelMinus.Size = new System.Drawing.Size(15, 24);
            this.toolStripLabelMinus.Text = "-";
            this.toolStripLabelMinus.Click += new System.EventHandler(this.toolStripLabelMinus_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSize,
            this.toolStripStatusLabelColors,
            this.toolStripStatusLabelStyle});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusSize
            // 
            this.toolStripStatusSize.Name = "toolStripStatusSize";
            this.toolStripStatusSize.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusSize.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelColors
            // 
            this.toolStripStatusLabelColors.Name = "toolStripStatusLabelColors";
            this.toolStripStatusLabelColors.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabelColors.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelStyle
            // 
            this.toolStripStatusLabelStyle.Name = "toolStripStatusLabelStyle";
            this.toolStripStatusLabelStyle.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabelStyle.Text = "toolStripStatusLabel1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.saveHeart;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.openChest;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // oathToolStripButton
            // 
            this.oathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oathToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.tatl;
            this.oathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oathToolStripButton.Name = "oathToolStripButton";
            this.oathToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.oathToolStripButton.Text = "Oath";
            this.oathToolStripButton.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.navi;
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.aboutToolStripButton.Text = "About";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // newWinToolStripButton
            // 
            this.newWinToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newWinToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.bossKey;
            this.newWinToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newWinToolStripButton.Name = "newWinToolStripButton";
            this.newWinToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newWinToolStripButton.Text = "New Window";
            this.newWinToolStripButton.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // ellipiseToolStripButton
            // 
            this.ellipiseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipiseToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.ellipseShape;
            this.ellipiseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipiseToolStripButton.Name = "ellipiseToolStripButton";
            this.ellipiseToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.ellipiseToolStripButton.Text = "Ellispe Shape";
            this.ellipiseToolStripButton.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // rectToolStripButton
            // 
            this.rectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.rectsShape;
            this.rectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectToolStripButton.Name = "rectToolStripButton";
            this.rectToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.rectToolStripButton.Text = "Rectangle Shape";
            this.rectToolStripButton.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // customToolStripButton
            // 
            this.customToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.customshape;
            this.customToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customToolStripButton.Name = "customToolStripButton";
            this.customToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.customToolStripButton.Text = "Custom Shape";
            this.customToolStripButton.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // solidPenToolStripButton
            // 
            this.solidPenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solidPenToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.largersolidpen;
            this.solidPenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidPenToolStripButton.Name = "solidPenToolStripButton";
            this.solidPenToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.solidPenToolStripButton.Text = "Solid Pen";
            this.solidPenToolStripButton.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // customDashedPenToolStripButton
            // 
            this.customDashedPenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customDashedPenToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.largerdashed;
            this.customDashedPenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customDashedPenToolStripButton.Name = "customDashedPenToolStripButton";
            this.customDashedPenToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.customDashedPenToolStripButton.Text = "Custom Dashed Pen";
            this.customDashedPenToolStripButton.Click += new System.EventHandler(this.customDashedToolStripMenuItem_Click);
            // 
            // CompoundToolStripButton
            // 
            this.CompoundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CompoundToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.compound;
            this.CompoundToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CompoundToolStripButton.Name = "CompoundToolStripButton";
            this.CompoundToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.CompoundToolStripButton.Text = "Compound Pen";
            this.CompoundToolStripButton.Click += new System.EventHandler(this.compoundToolStripMenuItem_Click);
            // 
            // solidBrushToolStripButton
            // 
            this.solidBrushToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solidBrushToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.solidbrush;
            this.solidBrushToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidBrushToolStripButton.Name = "solidBrushToolStripButton";
            this.solidBrushToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.solidBrushToolStripButton.Text = "Solid Brush";
            this.solidBrushToolStripButton.Click += new System.EventHandler(this.solidBrushToolStripMenuItem_Click);
            // 
            // hatchBrushToolStripButton
            // 
            this.hatchBrushToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hatchBrushToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.hatched;
            this.hatchBrushToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hatchBrushToolStripButton.Name = "hatchBrushToolStripButton";
            this.hatchBrushToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.hatchBrushToolStripButton.Text = "Hatch Brush";
            this.hatchBrushToolStripButton.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
            // 
            // linearGradientToolStripButton
            // 
            this.linearGradientToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linearGradientToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.linear;
            this.linearGradientToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linearGradientToolStripButton.Name = "linearGradientToolStripButton";
            this.linearGradientToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.linearGradientToolStripButton.Text = "Linear Gradient Brush";
            this.linearGradientToolStripButton.Click += new System.EventHandler(this.linearGradientToolStripMenuItem_Click);
            // 
            // penColorToolStripButton
            // 
            this.penColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penColorToolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.smallerpenColor;
            this.penColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penColorToolStripButton.Name = "penColorToolStripButton";
            this.penColorToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.penColorToolStripButton.Text = "Pen Color";
            this.penColorToolStripButton.Click += new System.EventHandler(this.penColorToolStripMenuItem_Click);
            // 
            // brushColortoolStripButton
            // 
            this.brushColortoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushColortoolStripButton.Image = global::Multi_SDI_Application.Properties.Resources.smallerBrushColor;
            this.brushColortoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushColortoolStripButton.Name = "brushColortoolStripButton";
            this.brushColortoolStripButton.Size = new System.Drawing.Size(24, 24);
            this.brushColortoolStripButton.Text = "Brush Color";
            this.brushColortoolStripButton.Click += new System.EventHandler(this.brushColorToolStripMenuItem_Click);
            // 
            // TopLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TopLevelForm";
            this.Text = "TopLevelForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopLevelForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopLevelForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopLevelForm_MouseUp);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.contextMenuStripShapes.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripShapes;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customDashedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPlus;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMinus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColors;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStyle;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton oathToolStripButton;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripButton newWinToolStripButton;
        private System.Windows.Forms.ToolStripButton ellipiseToolStripButton;
        private System.Windows.Forms.ToolStripButton rectToolStripButton;
        private System.Windows.Forms.ToolStripButton customToolStripButton;
        private System.Windows.Forms.ToolStripButton solidPenToolStripButton;
        private System.Windows.Forms.ToolStripButton customDashedPenToolStripButton;
        private System.Windows.Forms.ToolStripButton CompoundToolStripButton;
        private System.Windows.Forms.ToolStripButton solidBrushToolStripButton;
        private System.Windows.Forms.ToolStripButton hatchBrushToolStripButton;
        private System.Windows.Forms.ToolStripButton linearGradientToolStripButton;
        private System.Windows.Forms.ToolStripButton penColorToolStripButton;
        private System.Windows.Forms.ToolStripButton brushColortoolStripButton;
    }
}

