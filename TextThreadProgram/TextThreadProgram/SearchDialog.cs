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
using System.Threading;

namespace TextThreadProgram
{
    public partial class SearchDialog : BaseDialogForm
    {

        struct ThreadInfo
        {
            public string extension;
        }
        private ThreadInfo threadInfo;


        public SearchDialog()
        {
            InitializeComponent();
        }

        private void Search(string extension)
        {
            int index = 1;
            foreach (String drive in Directory.GetLogicalDrives())
            {
                DirectoryInfo[] directories = getDirectories(drive);
                for(int i = 0; i < directories.Length; ++i)
                {
                    if (!this.searchBackgroundWorker.CancellationPending)
                    {
                        this.searchBackgroundWorker.ReportProgress(index++ * 100 / directories.Length);
                        FindFiles(directories[i], extension);
                    }
                }
            }
        }

        private void FindFiles(DirectoryInfo dir, string extension)
        {
            try
            {
                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0)
                {
                    foreach (DirectoryInfo child in children)
                    {
                        FindFiles(child, extension);
                    }
                }
                else
                {
                    FileInfo[] Files = dir.GetFiles(extension);
                    if (Files.Length > 0)
                    {
                        for(int x = 0; x < Files.Length; ++x)
                        {
                            AddToList(Files[x].FullName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public DirectoryInfo[] getDirectories(DirectoryInfo dir)
        {
            if (AttrOn(dir.Attributes, FileAttributes.Offline))
            {
                return new DirectoryInfo[] { };
            }
            if (!dir.Exists)
            {
                return new DirectoryInfo[] { };
            }
            try
            {
                return dir.GetDirectories();
            }
            catch (Exception ex)
            {
                return new DirectoryInfo[] { };
            }
        }

        private bool AttrOn(FileAttributes attr, FileAttributes field)
        {
            return (attr & field) == field;
        }

        public DirectoryInfo[] getDirectories(String strDrive)
        {
            DirectoryInfo dir = new DirectoryInfo(strDrive);
            return getDirectories(dir);
        }


        void AddToList(string item)
        {
            if (this.listBoxAllFiles.InvokeRequired)
                this.listBoxAllFiles.Invoke((MethodInvoker)delegate ()
                {
                    AddToList(item);
                });
            else
                this.listBoxAllFiles.Items.Add(item);
        }

        private void startSearchBttn_Click(object sender, EventArgs e)
        {
            // once started there is no need for start anymore
            // but here is a need to stop or pause
            stopSearchBttn.Enabled = true;
            pauseSearchBttn.Enabled = true;
            startSearchBttn.Enabled = false;

            string selectedExtension = "*" + comboBoxExtension.SelectedItem.ToString();

            threadInfo.extension = selectedExtension;
            this.searchBackgroundWorker.RunWorkerAsync(threadInfo);
        }


        private void stopSearchBttn_Click(object sender, EventArgs e)
        {
            // once stopped there is no need for stopped anymore, or pausing
            // but here is a need to retart
            startSearchBttn.Enabled = true;
            stopSearchBttn.Enabled = false;
            pauseSearchBttn.Enabled = false;

            if (this.searchBackgroundWorker.IsBusy)
                this.searchBackgroundWorker.CancelAsync();

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

        private void searchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ThreadInfo arg = (ThreadInfo)e.Argument;
            Search(arg.extension);
        }

        private void searchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }
    }
}
