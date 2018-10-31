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

        // helper methods for searching from the text file from website

        //you will need System.IO and System.Diagnostics
        //Change the configuration to Debug to see a list of folders that are being read.
        //Change to release to see just the folders that cannot be read.
        //The search will be faster in Release configuration

        private void Search()
        {
            foreach (String drive in Directory.GetLogicalDrives())
            {
                Debug.WriteLine(drive);
                foreach (DirectoryInfo child in getDirectories(drive))
                {
                    Debug.WriteLine(child.FullName);
                    FindFiles(child);
                }
            }
        }

        private void FindFiles(DirectoryInfo dir)
        {
            try
            {
                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0)
                {
                    foreach (DirectoryInfo child in children)
                    {
                        Debug.WriteLine(child.FullName);
                        FindFiles(child);
                    }
                }
                else
                {
                    FileInfo[] Files = dir.GetFiles(comboBoxExtension.Text);
                    if (Files.Length > 0)
                    {
                        //Found some files.
                        //add to listbox something
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private bool AttrOn(FileAttributes attr, FileAttributes field)
        {
            return (attr & field) == field;
        }

        public DirectoryInfo[] getDirectories(DirectoryInfo dir)
        {
            if (AttrOn(dir.Attributes, FileAttributes.Offline))
            {
                Console.Out.WriteLine(dir.Name + " is not mapped ");
                return new DirectoryInfo[] { };
            }
            if (!dir.Exists)
            {
                Console.Out.WriteLine(dir.Name + " does not exist ");
                return new DirectoryInfo[] { };
            }
            try
            {
                return dir.GetDirectories();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
                return new DirectoryInfo[] { };
            }
        }

        public DirectoryInfo[] getDirectories(String strDrive)
        {
            DirectoryInfo dir = new DirectoryInfo(strDrive);
            return getDirectories(dir);
        }
    }
}
