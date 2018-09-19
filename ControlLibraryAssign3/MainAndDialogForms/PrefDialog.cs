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

namespace MainAndDialogForms
{
    public partial class PrefDialog : DialogBaseForm, ShapeInterface
    {
        public PrefDialog()
        {
            InitializeComponent();
            RectHeight = 0;
            Ratio = 0f;
            EllipWidth = 0;
        }

        //OK Button Handler
        private void okayButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(sender, e);
            this.Close();
        }

        //Apply Button Handler
        private void applyButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(sender, e);
        }

        //Cancel Button Handler
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Rectangle Height Variable From Interface
        public int rectHeight
        {
            get
            {
                return RectHeight;
            }
            set
            {
                RectHeight = value;
            }
        }

        //Ellipse Width Variable From Interface
        public int ellipseWidth
        {
            get
            {
                return EllipWidth;
            }
            set
            {
                EllipWidth = value;
            }
        }

        //Ratio Variable From Interface
        public float shapeRatio
        {
            get
            {
                return Ratio;
            }
            set
            {
                Ratio = (float)value;
            }
        }

        //Validation of TextBoxes
        public void ValidateTextBoxes(object sender, EventArgs e)
        {
            int textValue; //Dummy Variable for integers
            float floattext; //Dummy Variable for floats

            //First test for all textboxes is whether it is empty
            if (!string.Equals(RectBox.Text, ""))
            {
                //Attempt a parse, if failure, inform user of error
                if (int.TryParse(RectBox.Text, out textValue) && textValue > 0)
                {
                    RectError.Clear(); //Get rid of any previous error notification
                    RectHeight = textValue;
                    rectHeight = RectHeight;
                }
                else
                {
                    RectError.SetError(RectBox, "Must Enter Valid Integer Greater Than 0");
                }
            }
            else
            {
                RectError.SetError(RectBox, "Empty Text Box! Must Enter Valid Integer. Value Will Reamain Unchanged");
            }

            if (!string.Equals(EllipText.Text, ""))
            {
                if (int.TryParse(EllipText.Text, out textValue) && textValue > 0)
                {
                    EllipError.Clear();
                    EllipWidth = textValue;
                    ellipseWidth = EllipWidth;
                }
                else
                {
                    EllipError.SetError(EllipText, "Must Enter Valid Integer Greater Than 0");
                }
            }
            else
            {
                EllipError.SetError(EllipText, "Empty Text Box! Must Enter Valid Integer. Value Will Reamain Unchanged");
            }

            if (!string.Equals(RatioText.Text, ""))
            {
                if (float.TryParse(RatioText.Text, out floattext) && floattext > 0)
                {
                    RatioError.Clear();
                    Ratio = floattext;
                    shapeRatio = Ratio;
                }
                else
                {
                    RatioError.SetError(RatioText, "Must Enter Valid Float Greater Than 0");
                }
            }
            else
            {
                RatioError.SetError(RatioText, "Empty Text Box! Must Enter Valid Float. Value Will Reamain Unchanged");
            }
        }

        private int RectHeight;
        private int EllipWidth;
        private float Ratio;
    }
}
