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
        public event EventHandler applyEvent;

        public ShapeOptionsDialog(Shape shape, Document shapeContainer)
        {
            InitializeComponent();

            currentShape = shape;
            shapeCollection = shapeContainer;

            updateDialogValues();
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
            currentShape = shapeCollection.GetShape(currentShapeCombo.SelectedItem.ToString());
            updateDialogValues();
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

        private void okBttn_Click(object sender, EventArgs e)
        {
            if (validValues())
            {
                applyEvent(this, EventArgs.Empty);
            }
            this.Close();
        }

        private void applyBttn_Click(object sender, EventArgs e)
        {
            if(validValues())
            {
                applyEvent(this, EventArgs.Empty);
            }
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateDialogValues()
        {
            //Set Everything to Current Shape Properties
            widthBox.Text = currentShape.ShapeSize.Width.ToString();
            heightBox.Text = currentShape.ShapeSize.Height.ToString();

            xCoorBox.Text = currentShape.ShapeLoc.X.ToString();
            yCoorBox.Text = currentShape.ShapeLoc.Y.ToString();

            penColorBttn.BackColor = currentShape.PenColor;
            brushColorBttn.BackColor = currentShape.BrushColor;

            penTypeCombo.SelectedItem = currentShape.PenType;
            brushTypeCombo.SelectedItem = currentShape.BrushType;
            shapeTypeCombo.SelectedItem = currentShape.CurrentShape;

            currentShapeCombo.SelectedItem = currentShape.ShapeId;
        }

        private bool validValues()
        {
            return true;
        }
    }
}
