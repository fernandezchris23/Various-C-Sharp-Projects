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


        private void PrefDialog_Load(object sender, EventArgs e)
        {

        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

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

        private int RectHeight;
        private int EllipWidth;
        private float Ratio;


    }
}
