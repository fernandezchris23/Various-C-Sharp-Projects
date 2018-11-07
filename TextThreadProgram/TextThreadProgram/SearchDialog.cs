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
        public event EventHandler<MyEventArgs> doubleClickItem;

        private string extension; //The selected extension
        private int numOfDir;
        private int filesFound;
        private float numOfDirGoneThrough;
        private bool isPaused;
        private DirectoryInfo[] array; //Only used to get number of directories for progress bar

        public SearchDialog()
        {
            InitializeComponent();

            numOfDirGoneThrough = 0;
            numOfDir = 0;
            isPaused = false;
            extension = "";
            array = null;
            filesFound = 0;
        }

        private void Search()
        {
            foreach (String drive in Directory.GetLogicalDrives())
            {
                foreach (DirectoryInfo child in getDirectories(drive))
                {
                    if(this.searchBackgroundWorker.CancellationPending)
                    {
                        break;
                    }
                    while(isPaused) {} //Used to wait while paused
                    numOfDir = array.Length;
                    numOfDirGoneThrough += 0.5f;
                    if ((int)((numOfDirGoneThrough / (float)numOfDir) * 100) > 100)
                    {
                        this.searchBackgroundWorker.ReportProgress(100);
                    }
                    else
                    {
                        this.searchBackgroundWorker.ReportProgress((int)((numOfDirGoneThrough / (float)numOfDir) * 100));
                    }
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
                        FindFiles(child);
                    }
                }
                else
                {
                    FileInfo[] Files = dir.GetFiles(extension);
                    if (Files.Length > 0)
                    {
                        for (int x = 0; x < Files.Length; ++x)
                        {
                            AddToList(Files[x].FullName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //System.Console.WriteLine(ex.Message);
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
                //Console.Out.WriteLine(dir.Name + " is not mapped ");
                return new DirectoryInfo[] { };
            }
            if (!dir.Exists)
            {
                //Console.Out.WriteLine(dir.Name + " does not exist ");
                return new DirectoryInfo[] { };
            }
            try
            {
                if(array == null)
                {
                    array = dir.GetDirectories();
                }
                return dir.GetDirectories();
            }
            catch (Exception ex)
            {
                return new DirectoryInfo[] { };
            }
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
            {
                this.listBoxAllFiles.Items.Add(item);
                filesFound++;
            }
                
        }

        private void startSearchBttn_Click(object sender, EventArgs e)
        {
            if (this.searchBackgroundWorker.CancellationPending)
            {
                MessageBox.Show("Please wait while we finish ending the previous search...");
                return;
            }

            string selectedExtension = "";

            if (comboBoxExtension.SelectedItem == null)
            {
                MessageBox.Show("Must select an extension to perform the search!");
                return;
            }
            else
            {
                selectedExtension = comboBoxExtension.Text;
            }

            // once started there is no need for start anymore but there is a need to stop or pause
            stopSearchBttn.Enabled = true;
            pauseSearchBttn.Enabled = true;
            startSearchBttn.Enabled = false;

            extension = selectedExtension;
            this.searchBackgroundWorker.RunWorkerAsync();
        }

        private void stopSearchBttn_Click(object sender, EventArgs e)
        {
            // once stopped there is no need for stopped anymore, or paused but there is a need to retart
            startSearchBttn.Enabled = true;
            stopSearchBttn.Enabled = false;
            pauseSearchBttn.Enabled = false;
            this.progressBar.Value = 0;
            array = null;

            if (this.searchBackgroundWorker.IsBusy)
                this.searchBackgroundWorker.CancelAsync();
        }

        private void pauseSearchBttn_Click(object sender, EventArgs e)
        {
            if (pauseSearchBttn.Text == "Pause Search")
            {
                pauseSearchBttn.Text = "Continue Search";
                isPaused = true;

                // if paused turns to continue there is no need for a start button but there might be a need to stop
                startSearchBttn.Enabled = false;
                stopSearchBttn.Enabled = true;
            }
            else // it says continue search
            {
                pauseSearchBttn.Text = "Pause Search";
                isPaused = false;

                // if continue turns to pause there is still no need for a start button but there might be a need to stop
                startSearchBttn.Enabled = false;
                stopSearchBttn.Enabled = true;
            }
        }

        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.searchBackgroundWorker.IsBusy)
                this.searchBackgroundWorker.CancelAsync();
        }

        private void searchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Search();
        }

        private void SearchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        private void searchBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startSearchBttn.Enabled = true;
            stopSearchBttn.Enabled = false;
            pauseSearchBttn.Enabled = false;
            this.progressBar.Value = 100;
            MessageBox.Show("Search Completed. Files found: " + filesFound);
        }

        private void listBoxAllFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleClickItem(this, new MyEventArgs(listBoxAllFiles.Text));
        }
    }

    public class MyEventArgs : EventArgs
    {
        public string ListItemBeingPassed { get; set; }

        public MyEventArgs(string value)
        {
            ListItemBeingPassed = value;
        }
    }
}
