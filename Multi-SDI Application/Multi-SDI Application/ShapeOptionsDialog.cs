using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_SDI_Application
{
    public partial class ShapeOptionsDialog : Form
    {
        private Document shapeCollection;
        private Shape currentShape;
        private Color penColor, brushColor;
        private FileProperties fileProperties;

        public enum ShapeEnum { Ellipse, Rectangle, Custom };
        public enum PenEnum { Solid, Dashed, Compound };
        public enum BrushEnum { Solid, Hatched, LinearGradient };

        public ShapeOptionsDialog(Shape shape, Document shapeContainer, FileProperties fProperties)
        {
            fileProperties = fProperties;
            InitializeComponent();

            currentShape = shape;
            shapeCollection = shapeContainer;

            createComboBoxItems();

            updatePropertiesValues();

            InitBindings(fileProperties);
        }

        private void InitBindings(FileProperties fProperties)
        {
            widthBox.DataBindings.Add("Text", fileProperties, "ShapeWidth");
            heightBox.DataBindings.Add("Text", fileProperties, "ShapeHeight");
            xCoorBox.DataBindings.Add("Text", fileProperties, "ShapeX");
            yCoorBox.DataBindings.Add("Text", fileProperties, "ShapeY");

            penColorBttn.DataBindings.Add("BackColor", fileProperties, "PenColor");
            brushColorBttn.DataBindings.Add("BackColor", fileProperties, "BrushColor");

            penTypeCombo.DataBindings.Add("SelectedText", fileProperties, "PenType");
            brushTypeCombo.DataBindings.Add("SelectedText", fileProperties, "BrushType");
            shapeTypeCombo.DataBindings.Add("SelectedText", fileProperties, "ShapeType");
        }

        private void penColorBttn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                penColorBttn.BackColor = colorDialog.Color;
                penColor = colorDialog.Color;
            }
        }

        private void currentShapeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShape = shapeCollection.GetShape(currentShapeCombo.SelectedIndex);
        }

        private void brushColorBttn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                brushColorBttn.BackColor = colorDialog.Color;
                brushColor = colorDialog.Color;
            }
        }

        private void updatePropertiesValues()
        {
            //Set Everything to Current Shape Properties
            fileProperties.ShapeWidth = currentShape.ShapeSize.Width;
            fileProperties.ShapeHeight = currentShape.ShapeSize.Height;

            fileProperties.ShapeX = currentShape.ShapeLoc.X;
            fileProperties.ShapeY = currentShape.ShapeLoc.Y;

            fileProperties.PenColor = currentShape.PenColor;
            fileProperties.BrushColor = currentShape.BrushColor;

            fileProperties.PenType = currentShape.PenType.ToString();
            fileProperties.BrushType = currentShape.BrushType.ToString();
            fileProperties.ShapeType = currentShape.CurrentShape.ToString();

            currentShapeCombo.SelectedItem = currentShape.ShapeId;
        }

        private void createComboBoxItems()
        {
            penTypeCombo.DataSource = Enum.GetNames(typeof(PenEnum));
        }
    }
}
