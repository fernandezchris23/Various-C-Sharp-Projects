using System;
using ControlLibraryAssign3;

namespace MainAndDialogForms
{
    public partial class PrefDialog : DialogBaseForm, ShapeInterface
    {
        private int rectHeightLocal;
        private int ellipWidthLocal;
        private float RatioLocal;
        public event EventHandler applyBttnClick;

       //Interface Properties
        public int RectHeight
        {
            get { return rectHeightLocal; }
            set { rectHeightLocal = value; }
        }

        public int EllipseWidth
        {
            get { return ellipWidthLocal; }
            set { ellipWidthLocal = value; }
        }

        public float ShapeRatio
        {
            get { return RatioLocal; }
            set { RatioLocal = (float)value; }
        }

        public PrefDialog()
        {
            InitializeComponent();
            rectHeightLocal = 0;
            RatioLocal = 0f;
            ellipWidthLocal = 0;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(sender, e);
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(sender, e);
            applyBttnClick(this, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ValidateTextBoxes(object sender, EventArgs e)
        {
            int textValue;
            float floattext;
            if (!string.Equals(RectBox.Text, ""))
            {
                if (int.TryParse(RectBox.Text, out textValue) && textValue > 0)
                {
                    RectError.Clear();
                    rectHeightLocal = textValue;
                    RectHeight = rectHeightLocal;
                }
                else
                {
                    RectError.SetError(RectBox, "Must Enter Valid Integer Greater Than 0");
                }
            }
            else
            {
                RectError.SetError(RectBox, "Empty Text Box! Must Enter Valid Integer Greater Than 0");
            }
            if (!string.Equals(EllipText.Text, ""))
            {
                if (int.TryParse(EllipText.Text, out textValue) && textValue > 0)
                {
                    EllipError.Clear();
                    ellipWidthLocal = textValue;
                    EllipseWidth = ellipWidthLocal;
                }
                else
                {
                    EllipError.SetError(EllipText, "Must Enter Valid Integer Greater Than 0");
                }
            }
            else
            {
                EllipError.SetError(EllipText, "Empty Text Box! Must Enter Valid Integer Greater Than 0");
            }
            if (!string.Equals(RatioText.Text, ""))
            {
                if (float.TryParse(RatioText.Text, out floattext) && floattext > 0)
                {
                    RatioError.Clear();
                    RatioLocal = floattext;
                    ShapeRatio = RatioLocal;
                }
                else
                {
                    RatioError.SetError(RatioText, "Must Enter Valid Float Greater Than 0");
                }
            }
            else
            {
                RatioError.SetError(RatioText, "Empty Text Box! Must Enter Valid Float Greater Than 0");
            }
        }

    }
}
