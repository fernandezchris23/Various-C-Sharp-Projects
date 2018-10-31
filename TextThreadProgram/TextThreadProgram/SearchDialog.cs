﻿using System;
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
        static List<DirectoryInfo> folders = new List<DirectoryInfo>(); // List that hold direcotries that cannot be accessed

        public SearchDialog()
        {
            InitializeComponent();
        }

        delegate void FileDelegate(string filePath, string fileExtension);

        void FindFiles(string filePath, string fileExtension)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            List<FileInfo> files = new List<FileInfo>();
            Console.WriteLine(filePath + " " + directoryInfo.GetFiles(fileExtension).Count());
            try
            {
                foreach (FileInfo f in directoryInfo.GetFiles(fileExtension))
                {
                    Console.WriteLine("File {0}", f.FullName);
                    files.Add(f);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        void EndFiles(IAsyncResult result)
        {

            try
            {
                FileDelegate thread = (FileDelegate)result.AsyncState;
                thread.EndInvoke(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // process each directory
            // If I have been able to see the files in the directory I should also be able 
            // to look at its directories so I dont think I should place this in a try catch block
            /*
            foreach (DirectoryInfo d in directoryInfo.GetDirectories())
            {
                folders.Add(d);
                Console.WriteLine(d.FullName);
                //FullDirList(d, searchPattern);
            }*/
        }

        private void startSearchBttn_Click(object sender, EventArgs e)
        {
            // once started there is no need for start anymore
            // but here is a need to stop or pause
            stopSearchBttn.Enabled = true;
            pauseSearchBttn.Enabled = true;
            startSearchBttn.Enabled = false;

            string selectedExtension = comboBoxExtension.SelectedItem.ToString();
            string path = "C:\\Users\\alvar\\Desktop";


            FileDelegate thread = new FileDelegate(FindFiles);
            thread.BeginInvoke(
                path, selectedExtension,
                EndFiles,
                thread
                );
            
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
