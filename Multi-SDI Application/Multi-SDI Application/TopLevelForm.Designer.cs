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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopLevelForm));
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
            this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.oathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newWinToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ellispeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.recToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.solidToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.custDashToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.compoundToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.solidBrushtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.hatchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.linearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.penColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.brushColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripShapes.SuspendLayout();
            this.toolStrip.SuspendLayout();
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
            this.solidToolStripMenuItem1,
            this.hatchToolStripMenuItem,
            this.linearGradientToolStripMenuItem});
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.solidToolStripMenuItem1.Text = "Solid";
            this.solidToolStripMenuItem1.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
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
            this.saveToolStripButton,
            this.openToolStripButton,
            this.oathToolStripButton,
            this.aboutToolStripButton,
            this.newWinToolStripButton,
            this.ellispeToolStripButton,
            this.recToolStripButton,
            this.customToolStripButton,
            this.solidToolStripButton,
            this.custDashToolStripButton,
            this.compoundToolStripButton,
            this.solidBrushtoolStripButton,
            this.hatchToolStripButton,
            this.linearToolStripButton,
            this.penColorToolStripButton,
            this.brushColorToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
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
            this.oathToolStripButton.Text = "Oath ";
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
            // ellispeToolStripButton
            // 
            this.ellispeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellispeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ellispeToolStripButton.Image")));
            this.ellispeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellispeToolStripButton.Name = "ellispeToolStripButton";
            this.ellispeToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.ellispeToolStripButton.Text = "Ellipse";
            this.ellispeToolStripButton.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // recToolStripButton
            // 
            this.recToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recToolStripButton.Image")));
            this.recToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recToolStripButton.Name = "recToolStripButton";
            this.recToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.recToolStripButton.Text = "Rectangle";
            this.recToolStripButton.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // customToolStripButton
            // 
            this.customToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("customToolStripButton.Image")));
            this.customToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customToolStripButton.Name = "customToolStripButton";
            this.customToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.customToolStripButton.Text = "Custom";
            this.customToolStripButton.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // solidToolStripButton
            // 
            this.solidToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solidToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("solidToolStripButton.Image")));
            this.solidToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidToolStripButton.Name = "solidToolStripButton";
            this.solidToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.solidToolStripButton.Text = "Solid Pen";
            this.solidToolStripButton.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // custDashToolStripButton
            // 
            this.custDashToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.custDashToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("custDashToolStripButton.Image")));
            this.custDashToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.custDashToolStripButton.Name = "custDashToolStripButton";
            this.custDashToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.custDashToolStripButton.Text = "Custom Dashed Pen";
            this.custDashToolStripButton.Click += new System.EventHandler(this.customDashedToolStripMenuItem_Click);
            // 
            // compoundToolStripButton
            // 
            this.compoundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compoundToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("compoundToolStripButton.Image")));
            this.compoundToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compoundToolStripButton.Name = "compoundToolStripButton";
            this.compoundToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.compoundToolStripButton.Text = "Compound Pen";
            this.compoundToolStripButton.Click += new System.EventHandler(this.compoundToolStripMenuItem_Click);
            // 
            // solidBrushtoolStripButton
            // 
            this.solidBrushtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solidBrushtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("solidBrushtoolStripButton.Image")));
            this.solidBrushtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidBrushtoolStripButton.Name = "solidBrushtoolStripButton";
            this.solidBrushtoolStripButton.Size = new System.Drawing.Size(24, 24);
            this.solidBrushtoolStripButton.Text = "Solid Brush";
            this.solidBrushtoolStripButton.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
            // 
            // hatchToolStripButton
            // 
            this.hatchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hatchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("hatchToolStripButton.Image")));
            this.hatchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hatchToolStripButton.Name = "hatchToolStripButton";
            this.hatchToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.hatchToolStripButton.Text = "Hatch Brush";
            this.hatchToolStripButton.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
            // 
            // linearToolStripButton
            // 
            this.linearToolStripButton.AutoToolTip = false;
            this.linearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linearToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("linearToolStripButton.Image")));
            this.linearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linearToolStripButton.Name = "linearToolStripButton";
            this.linearToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.linearToolStripButton.Text = "Linear Gradient Brush";
            this.linearToolStripButton.Click += new System.EventHandler(this.linearGradientToolStripMenuItem_Click);
            // 
            // penColorToolStripButton
            // 
            this.penColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("penColorToolStripButton.Image")));
            this.penColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penColorToolStripButton.Name = "penColorToolStripButton";
            this.penColorToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.penColorToolStripButton.Text = "Pen Color";
            this.penColorToolStripButton.Click += new System.EventHandler(this.penColorToolStripMenuItem_Click);
            // 
            // brushColorToolStripButton
            // 
            this.brushColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("brushColorToolStripButton.Image")));
            this.brushColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushColorToolStripButton.Name = "brushColorToolStripButton";
            this.brushColorToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.brushColorToolStripButton.Text = "Brush Color";
            this.brushColorToolStripButton.Click += new System.EventHandler(this.brushColorToolStripMenuItem_Click);
            // 
            // TopLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TopLevelForm";
            this.Text = "TopLevelForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopLevelForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopLevelForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopLevelForm_MouseUp);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.contextMenuStripShapes.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton oathToolStripButton;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripButton newWinToolStripButton;
        private System.Windows.Forms.ToolStripButton ellispeToolStripButton;
        private System.Windows.Forms.ToolStripButton recToolStripButton;
        private System.Windows.Forms.ToolStripButton customToolStripButton;
        private System.Windows.Forms.ToolStripButton solidToolStripButton;
        private System.Windows.Forms.ToolStripButton custDashToolStripButton;
        private System.Windows.Forms.ToolStripButton compoundToolStripButton;
        private System.Windows.Forms.ToolStripButton solidBrushtoolStripButton;
        private System.Windows.Forms.ToolStripButton hatchToolStripButton;
        private System.Windows.Forms.ToolStripButton linearToolStripButton;
        private System.Windows.Forms.ToolStripButton penColorToolStripButton;
        private System.Windows.Forms.ToolStripButton brushColorToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPlus;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMinus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColors;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStyle;
    }
}

