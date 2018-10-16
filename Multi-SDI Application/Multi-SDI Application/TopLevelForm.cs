using System;
using System.Windows.Forms;
using System.Drawing;
using ControlLibraryAssign3;
using System.ComponentModel;

namespace Multi_SDI_Application
{
    public partial class TopLevelForm : BaseMainForm
    {
        //Variables
        private string filename { get; set; }
        private string fileFilter;
        private SerializableProperties serializableProperties;
        private Shape currentShape;
        private Boolean isDrawing;
        public static int count = 0;
        private Document document;

        public TopLevelForm()
        {
            InitializeComponent();
            serializableProperties = new SerializableProperties();
            fileFilter = "Files|*.ok";
            
            //Set more menu
            ToolStripMenuItem item = new ToolStripMenuItem("More");
            item.DropDown = contextMenuStripShapes;
            this.menuStrip.Items.Insert(menuStrip.Items.Count, item);

            //Create shape object
            document = new Document();
            currentShape = new Shape(SerializableProperties.ShapeEnum.Ellipse, SerializableProperties.BrushEnum.Solid, SerializableProperties.PenEnum.Solid);
            isDrawing = false;
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

            if (Serializer.Serialize(saveFileDialog.FileName, serializableProperties))
                Console.WriteLine(saveFileDialog.FileName + " saved succesfully");
            else
                Console.WriteLine("Failed to save file");
        }

        
        public override void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileFilter;
            openFileDialog.Title = "Select file to open";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            SerializableProperties temp;
            if ((temp = Serializer.Deserialize(openFileDialog.FileName)) != null)
                serializableProperties = temp;
            else
                Console.WriteLine("Failed");
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
            Console.WriteLine("Current shape is " + currentShape.CurrentShape);
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.CurrentShape = SerializableProperties.ShapeEnum.Rectangle;
            Console.WriteLine("Current shape is " + currentShape.CurrentShape);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.CurrentShape = SerializableProperties.ShapeEnum.Custom;
            Console.WriteLine("Current shape is " + currentShape.CurrentShape);
        }

        //
        // Pen
        //
        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.PenType = SerializableProperties.PenEnum.Solid;
            Console.WriteLine("Current pen is " + currentShape.PenType);

        }

        private void customDashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.PenType = SerializableProperties.PenEnum.Dashed;
            Console.WriteLine("Current pen is " + currentShape.PenType);
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.PenType = SerializableProperties.PenEnum.Compound;
            Console.WriteLine("Current pen is " + currentShape.PenType);
        }

        //
        // Brushes
        //
        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentShape.BrushType = SerializableProperties.BrushEnum.Solid;
            Console.WriteLine("Current brush is " + currentShape.BrushType);
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.BrushType = SerializableProperties.BrushEnum.Hatched;
            Console.WriteLine("Current brush is " + currentShape.BrushType);
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.BrushType = SerializableProperties.BrushEnum.LinearGradient;
            Console.WriteLine("Current brush is " + currentShape.BrushType);
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
            Console.WriteLine("PenColor = " + currentShape.PenColor);
        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentShape.BrushColor = GetColor();
            Console.WriteLine("BrushColor = " + currentShape.BrushColor);
        }

        private void TopLevelForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void TopLevelForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            Console.WriteLine("size of document = " + document.countShapes());
        }

        private void TopLevelForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            //Get cursor positions
            currentShape.ShapeLoc = new Point(e.X, e.Y);

            //Add to document
            document.Add(currentShape);

            //Draw
            using (Graphics g = this.CreateGraphics())
            {
                switch(currentShape.CurrentShape)
                {
                    case SerializableProperties.ShapeEnum.Ellipse:
                        g.FillEllipse(currentShape.GetBrush(), currentShape.GetShape());
                        break;
                    case SerializableProperties.ShapeEnum.Rectangle:
                        g.FillRectangle(currentShape.GetBrush(), currentShape.GetShape());
                        break;
                    case SerializableProperties.ShapeEnum.Custom: //Update this
                        g.FillRectangle(currentShape.GetBrush(), currentShape.GetShape());
                        break;
                }

            }
           
        }
    }
}
