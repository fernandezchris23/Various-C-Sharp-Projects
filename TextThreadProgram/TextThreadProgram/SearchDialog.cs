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
            // once started there is no need for start anymore
            // but here is a need to stop or pause
            stopSearchBttn.Enabled = true;
            pauseSearchBttn.Enabled = true;
            startSearchBttn.Enabled = false;
            
        }

        private void stopSearchBttn_Click(object sender, EventArgs e)
        {
            // once stopped there is no need for stopped anymore, or pausing
            // but here is a need to retart
            startSearchBttn.Enabled = true;
            stopSearchBttn.Enabled = false;
            pauseSearchBttn.Enabled = false;
        }

        private void pauseSearchBttn_Click(object sender, EventArgs e)
        {
            if (pauseSearchBttn.Text == "Pause Search")
            {
                pauseSearchBttn.Text = "Continue Search";

                // if paused turns to continue there is no need for a start button 
                // but there might be a need to stop
                startSearchBttn.Enabled = false;
                stopSearchBttn.Enabled = true;

                // add code here to stop searching
            }
            else // it says continue search
            {
                pauseSearchBttn.Text = "Pause Search";

                // if continue turns to pause there is still no need for a start button 
                // but there might be a need to stop
                startSearchBttn.Enabled = false;
                stopSearchBttn.Enabled = true;

                // add code here to start searching
            }
        }

        private void comboBoxExtension_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // make sure to stop search if the form is closed
        }
    }
}
