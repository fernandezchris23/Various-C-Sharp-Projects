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

            createHelpInfo();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            if(ValidateTextBoxes(sender, e))
            {
                if(!this.Modal)
                {
                    applyBttnClick(this, EventArgs.Empty);
                }
                this.Close();
            }            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(ValidateTextBoxes(sender, e))
            {
                applyBttnClick(this, EventArgs.Empty);
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidateTextBoxes(object sender, EventArgs e)
        {
            int textValue;
            float floattext;
            if (!string.Equals(RectBox.Text, ""))
            {
                if (int.TryParse(RectBox.Text, out textValue) && textValue > 0)
                {
                    rectHeightLocal = textValue;
                    RectHeight = rectHeightLocal;
                }
                else
                {
                    errorProvider.SetError(cancelButton, "Must Enter Valid Integer Greater Than 0 For Rectangle Height and Ellipse Width\n" +
                        "and a valid float greater than 0 for ratio");
                    return false;
                }
            }
            else
            {
                errorProvider.SetError(cancelButton, "Empty Text Box! Must Enter a Valid Value!");
                return false;
            }
            if (!string.Equals(EllipText.Text, ""))
            {
                if (int.TryParse(EllipText.Text, out textValue) && textValue > 0)
                {
                    ellipWidthLocal = textValue;
                    EllipseWidth = ellipWidthLocal;
                }
                else
                {
                    errorProvider.SetError(cancelButton, "Must Enter Valid Integer Greater Than 0 For Rectangle Height and Ellipse Width\n" +
                        "and a valid float greater than 0 for ratio");
                    return false;
                }
            }
            else
            {
                errorProvider.SetError(cancelButton, "Empty Text Box! Must Enter a Valid Value!");
                return false;
            }
            if (!string.Equals(RatioText.Text, ""))
            {
                if (float.TryParse(RatioText.Text, out floattext) && floattext > 0)
                {
                    RatioLocal = floattext;
                    ShapeRatio = RatioLocal;
                }
                else
                {
                    errorProvider.SetError(cancelButton, "Must Enter Valid Integer Greater Than 0 For Rectangle Height and Ellipse Width\n" +
                        "and a valid float greater than 0 for ratio");
                    return false;
                }
            }
            else
            {
                errorProvider.SetError(cancelButton, "Empty Text Box! Must Enter a Valid Value!");
                return false;
            }
            return true;
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
            rectHeightLocal = RectHeight;
            RatioLocal = ShapeRatio;
            ellipWidthLocal = EllipseWidth;

            RectBox.Text = rectHeightLocal.ToString();
            EllipText.Text = ellipWidthLocal.ToString();
            RatioText.Text = RatioLocal.ToString();

            if (this.Modal)
            {
                applyButton.Enabled = false;
                applyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            }
        }
    }
}
