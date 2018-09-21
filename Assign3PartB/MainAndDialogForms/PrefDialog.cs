using System;
using ControlLibraryAssign3;

namespace MainAndDialogForms
{
    public partial class PrefDialog : DialogBaseForm, ShapeInterface
    {
        private int RectHeight;
        private int EllipWidth;
        private float Ratio;
        private MainForm mainForm;
        
        public PrefDialog()
        {
            InitializeComponent();
            RectHeight = 0;
            Ratio = 0f;
            EllipWidth = 0;
            mainForm = null;
        }

        public PrefDialog(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            RectHeight = 0;
            Ratio = 0f;
            EllipWidth = 0;
        }

        private void PrefDialog_Load(object sender, EventArgs e)
        {
        }

        private void UpdateMainForm()
        {
            if (mainForm != null)
                mainForm.SetVariables(this);
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(sender, e);
            UpdateMainForm();
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(sender, e);
            UpdateMainForm();
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
                RectError.SetError(RectBox, "Empty Text Box! Must Enter Valid Integer");
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
                EllipError.SetError(EllipText, "Empty Text Box! Must Enter Valid Integer");
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
                RatioError.SetError(RatioText, "Empty Text Box! Must Enter Valid Float");
            }
        }

        public MainForm MainForm
        {
            get { return mainForm; }
            set { mainForm = value;  }
        }

        public int rectHeight
        {
            get { return RectHeight; }
            set { RectHeight = value; }
        }

        public int ellipseWidth
        {
            get { return EllipWidth; }
            set { EllipWidth = value; }
        }

        public float shapeRatio
        {
            get { return Ratio; }
            set { Ratio = (float)value; }
        }

    }
}
