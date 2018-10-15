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
            widthBox.Text = currentShape.shapeSize.Width.ToString();
            heightBox.Text = currentShape.shapeSize.Height.ToString();

            xCoorBox.Text = currentShape.shapeLoc.X.ToString();
            yCoorBox.Text = currentShape.shapeLoc.Y.ToString();

            penColorBttn.BackColor = currentShape.penColor;
            brushColorBttn.BackColor = currentShape.brushColor;

            penTypeCombo.SelectedItem = currentShape.penType;
            brushTypeCombo.SelectedItem = currentShape.brushType;
            shapeTypeCombo.SelectedItem = currentShape.shape;

            currentShapeCombo.SelectedItem = currentShape.shapeId;
        }

        private bool validValues()
        {
            return true;
        }
    }
}
