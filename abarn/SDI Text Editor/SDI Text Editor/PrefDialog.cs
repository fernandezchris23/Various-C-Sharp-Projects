using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDI_Text_Editor
{
    public partial class PrefDialog : Form
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

        private void okayButton_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
                        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
