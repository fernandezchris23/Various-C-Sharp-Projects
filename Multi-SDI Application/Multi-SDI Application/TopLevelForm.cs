using System;
using System.Windows.Forms;
using System.Drawing;
using ControlLibraryAssign3;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Multi_SDI_Application
{
    public partial class TopLevelForm : BaseMainForm
    {
        //Variables
        private string filename { get; set; }
        private string fileFilter;
        private Shape currentShape;
        private Boolean isDrawing;
        public static int count = 0;
        private Document document;
        private Boolean isBrush;
        private Shape touchedShape;

        public TopLevelForm()
        {
            InitializeComponent();
            fileFilter = "Files|*.ok";
            
            //Set more menu
            ToolStripMenuItem item = new ToolStripMenuItem("More");
            item.DropDown = contextMenuStripShapes;
            this.menuStrip.Items.Insert(menuStrip.Items.Count, item);

            //Create shape object
            document = new Document();
            currentShape = new Shape(SerializableProperties.ShapeEnum.Ellipse, SerializableProperties.BrushEnum.Solid, SerializableProperties.PenEnum.Solid);
            isDrawing = false;
            isBrush = true;
            touchedShape = null;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            this.toolStripStatusSize.BackColor = Color.Thistle;
            this.toolStripStatusSize.ForeColor = Color.White;
            this.toolStripStatusSize.Text = "Width: " + currentShape.ShapeSize.Width + " | " + "Height: " + currentShape.ShapeSize.Height;

            this.toolStripStatusLabelColors.BackColor = Color.Brown;
            this.toolStripStatusLabelColors.ForeColor = Color.White;
            this.toolStripStatusLabelColors.Text = "Brush: " + currentShape.BrushColor.Name + " | " + " Pen: " + currentShape.PenColor.Name;

            this.toolStripStatusLabelStyle.BackColor = Color.Black;
            this.toolStripStatusLabelStyle.ForeColor = Color.White;
            this.toolStripStatusLabelStyle.Text = "Brush: " + currentShape.BrushType + " | " + " Pen: " + currentShape.PenType;
        }

        //Creates new top level window
        public static TopLevelForm CreateWindow(string filename)
        {
            if (!String.IsNullOrEmpty(filename))
            {
                foreach(TopLevelForm form in Application.OpenForms)
                {
                    if (String.Compare(form.filename, filename, true) == 0) //Checks if file is already open
                    {
                        form.Activate();
                        return form;
                    }
                }
            }

            TopLevelForm newForm = new TopLevelForm();
            ++count;
           // newForm.OpenFile(filename);
            newForm.Show();
            newForm.Text = "Untitled " + count;
            newForm.Activate();
            return newForm;
        }

        private void OpenFile(String filename)
        {
            
        }

        //Override of Oath Tool Strip Menu Item Handler
        public override void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OathDialog oathDlg = new OathDialog();
            oathDlg.Owner = this;

            try
            {
                oathDlg.Show();
            } catch
            {
                throw new NotSupportedException("Oath Dialog not supported");
            }
            
        }

        //Override of About Tool Strip Menu Item Handler
        public override void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog abtDlg = new AboutDialog();
            abtDlg.Owner = this;

            try
            {
                abtDlg.Show();
            }
            catch
            {
                throw new NotSupportedException("About Dialog not supported");
            }
        }

        //Override of New Window Tool Strip Menu Item Handler
        public override void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWindow("");
            updateWindowMenu();
        }

        public override void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = fileFilter;
            saveFileDialog.Title = "Save file";

            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            //Shape[] shapes = new Shape[document.Components.Count]; 
            //document.Components.CopyTo(shapes, 0);

            if (Serializer.Serialize(saveFileDialog.FileName, document))
                MessageBox.Show(saveFileDialog.FileName + " saved succesfully");
            else
                MessageBox.Show("Failed to save file");
        }

        
        public override void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileFilter;
            openFileDialog.Title = "Select file to open";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            object temp;
            if ((temp = Serializer.Deserialize(openFileDialog.FileName)) != null)
            {
                document = (Document)temp;
                RedrawGraphics();
            }
            else
                MessageBox.Show("Failed to load file");
        }

        private void RedrawGraphics()
        {
            foreach(Shape shape in document.Components)
            {
                DrawGraphic(shape);
            }
        }

        private void DrawGraphic(Shape shape)
        {
            using (Graphics g = this.CreateGraphics())
            {
                switch (shape.CurrentShape)
                {
                    case SerializableProperties.ShapeEnum.Ellipse:
                        if (isBrush)
                            g.FillEllipse(shape.GetBrush(), shape.GetShape());
                        else
                            g.DrawEllipse(shape.GetPen(), shape.GetShape());
                        break;
                    case SerializableProperties.ShapeEnum.Rectangle:
                        if (isBrush)
                            g.FillRectangle(shape.GetBrush(), shape.GetShape());
                        else
                            g.DrawRectangle(shape.GetPen(), shape.GetShape());
                        break;
                    case SerializableProperties.ShapeEnum.Custom: //Update this
                        if (isBrush)
                            g.FillRectangle(shape.GetBrush(), shape.GetShape());
                        else
                            g.DrawRectangle(shape.GetPen(), shape.GetShape());
                        break;
                }

            }
        }

        //Used to update the Window Menu Items
        private void updateWindowMenu()
        {
            
        }

        //
        // Shape
        //
        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.CurrentShape = SerializableProperties.ShapeEnum.Ellipse;
            UpdateLabels();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.CurrentShape = SerializableProperties.ShapeEnum.Rectangle;
            UpdateLabels();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.CurrentShape = SerializableProperties.ShapeEnum.Custom;
            UpdateLabels();
        }

        //
        // Pen
        //
        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.PenType = SerializableProperties.PenEnum.Solid;
            isBrush = false;
            UpdateLabels();
        }

        private void customDashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.PenType = SerializableProperties.PenEnum.Dashed;
            isBrush = false;
            UpdateLabels();
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.PenType = SerializableProperties.PenEnum.Compound;
            isBrush = false;
            UpdateLabels();
        }

        //
        // Brushes
        //
        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentShape.BrushType = SerializableProperties.BrushEnum.Solid;
            isBrush = true;
            UpdateLabels();
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.BrushType = SerializableProperties.BrushEnum.Hatched;
            isBrush = true;
            UpdateLabels();
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.BrushType = SerializableProperties.BrushEnum.LinearGradient;
            isBrush = true;
            UpdateLabels();
        }


        private Color GetColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
                return colorDialog.Color;

            return Color.Black;
        }

        //
        // Color
        //
        private void penColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.PenColor = GetColor();
            UpdateLabels();
        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.BrushColor = GetColor();
            UpdateLabels();
        }

        private void TopLevelForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;

            foreach (Shape shape in document.Components)
            {
                if (e.X > shape.ShapeLoc.X && (e.X < shape.ShapeLoc.X + shape.ShapeSize.Width))
                {
                    touchedShape = shape;
                    Console.WriteLine("Within bounds!!!");
                }
            }

            if(touchedShape == null)
            {
                //Get cursor positions
                currentShape.ShapeLoc = new Point(e.X, e.Y);

                Shape ttshape = new Shape(currentShape.CurrentShape, currentShape.BrushType, currentShape.PenType);
                ttshape.ShapeLoc = currentShape.ShapeLoc;
                ttshape.ShapeSize = currentShape.ShapeSize;

                //Add to document
                document.Add(ttshape);

                //Draw
                DrawGraphic(ttshape);
            }

        }

        private void TopLevelForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            if(touchedShape != null)
            {
                this.Invalidate();
                touchedShape.ShapeSize = new Size(touchedShape.ShapeSize.Width + 1, touchedShape.ShapeSize.Height + 1);
                DrawGraphic(touchedShape);
            }

        }

        private void TopLevelForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            touchedShape = null;
            RedrawGraphics();
        }

        private void toolStripLabelPlus_Click(object sender, EventArgs e)
        {
            currentShape.ShapeSize = new Size(currentShape.ShapeSize.Width + 1, currentShape.ShapeSize.Height + 1);
            UpdateLabels();
        }

        private void toolStripLabelMinus_Click(object sender, EventArgs e)
        {
            currentShape.ShapeSize = new Size(currentShape.ShapeSize.Width - 1, currentShape.ShapeSize.Height - 1);
            UpdateLabels();
        }

      
    }
}
