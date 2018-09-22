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

            createHelpInfo();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(sender, e);
            if(!this.Modal)
            {
                applyBttnClick(this, EventArgs.Empty);
            }
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

        private void createHelpInfo()
        {
            helpProvider.SetShowHelp(RectBox, true);
            helpProvider.SetHelpString(RectBox, "This box will hold the height of the rectangle as a positive, non-zero integer.");

            helpProvider.SetShowHelp(EllipText, true);
            helpProvider.SetHelpString(EllipText, "This box will hold the width of the ellipse as a positive, non-zero integer.");

            helpProvider.SetShowHelp(RatioText, true);
            helpProvider.SetHelpString(RatioText, "This box will hold the ratio used for calculating the width of the rectangle and the width of the ellipse.");

            helpProvider.SetShowHelp(okayButton, true);
            helpProvider.SetHelpString(okayButton, "Saves the values entered and closes the dialog.");

            helpProvider.SetShowHelp(applyButton, true);
            helpProvider.SetHelpString(applyButton, "Saves the values entered. Only available to modeless dialogs.");

            helpProvider.SetShowHelp(cancelButton, true);
            helpProvider.SetHelpString(cancelButton, "Closes the dialog without saving the values.");
        }

        private void PrefDialog_Load(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                applyButton.Enabled = false;
                applyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            }
        }
    }
}
