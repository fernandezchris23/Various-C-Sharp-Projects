using System;
using ControlLibraryAssign3;
using System.Windows.Forms;

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
            if (!this.ValidateChildren()) // validates modal preference dialog
                DialogResult = DialogResult.None;  
            else if (this.ValidateChildren()) // validates modeless preference dialog
            {
                if (!this.Modal)
                {
                    applyBttnClick(this, EventArgs.Empty);
                }
                this.Close();

            }            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyBttnClick(this, EventArgs.Empty);   
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RectBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!string.Equals(RectBox.Text, ""))
            {
                if (int.TryParse(RectBox.Text, out int textValue) && (textValue > 19 && textValue < 1000))
                {
                    rectHeightLocal = textValue;
                    RectHeight = rectHeightLocal;
                }
                else
                {
                    errorProvider.SetError(RectBox, "Must Enter Valid Integer Greater Than 19 and Less Than 1000 For Rectangle Height and Custom Width");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(RectBox, "Empty Text Box! Must Enter a Valid Value!");
                e.Cancel = true;
            }
        }

        private void EllipText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!string.Equals(EllipText.Text, ""))
            {
                if (int.TryParse(EllipText.Text, out int textValue) && (textValue > 19 && textValue < 1000))
                {
                    ellipWidthLocal = textValue;
                    EllipseWidth = ellipWidthLocal;
                }
                else
                {
                    errorProvider.SetError(EllipText, "Must Enter Valid Integer Greater Than 19 and Less Than 1000 for Ellipse");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(EllipText, "Empty Text Box! Must Enter a Valid Value!");
                e.Cancel = true;
            }
        }

        private void RatioText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.Equals(RatioText.Text, ""))
            {
                if (float.TryParse(RatioText.Text, out float floattext) && (floattext > 0 && floattext < 10))
                {
                    RatioLocal = floattext;
                    ShapeRatio = RatioLocal;
                }
                else
                {
                    errorProvider.SetError(RatioText, "Must Enter Valid Float Greater Than 0 and Less Than 10 for Ratio");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(RatioText, "Empty Text Box! Must Enter a Valid Value!");
                e.Cancel = true;
            }
        }
    }
}
