using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary;
using System.IO;
using System.Diagnostics;

namespace TextThreadProgram
{
    public partial class SearchDialog : BaseDialogForm
    {
        public SearchDialog()
        {
            InitializeComponent();
        }

        private void startSearchBttn_Click(object sender, EventArgs e)
        {

        }

        private void stopSearchBttn_Click(object sender, EventArgs e)
        {

        }

        private void pauseSearchBttn_Click(object sender, EventArgs e)
        {
            if (pauseSearchBttn.Text == "Pause Search")
            {
                pauseSearchBttn.Text = "Continue Search";
                // add code here to stop searching
            }
            else // it says continue search
            {
                pauseSearchBttn.Text = "Pause Search";
                // add code here to start searching
            }
        }

        private void comboBoxExtension_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
