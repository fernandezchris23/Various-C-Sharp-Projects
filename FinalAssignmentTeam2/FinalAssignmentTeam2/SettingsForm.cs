using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FinalAssignmentTeam2
{
    public partial class SettingsForm : Form
    {
        private SettingsProperties outProperties;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;

        public SettingsForm(SettingsProperties passed)
        {
            outProperties = passed;
            InitializeComponent();
            InitBindings();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog = new PrintPreviewDialog();
        }

        private void InitBindings()
        {
            homePageTextBox.DataBindings.Add("Text", outProperties, "HomePage");
            numMinutesNotifyNumericUpDown.DataBindings.Add("Value", outProperties, "NumMinutesForNotify");
            notifyCheckBox.DataBindings.Add("Checked", outProperties, "NotifyOff");
        }

        private void okBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStrip_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = PrintSetup(e.Graphics);
        }

        private Graphics PrintSetup(Graphics g)
        {
            g.DrawString("TEAM 2 Webbrowser: Settings page", new Font("Lucida Console", 12), Brushes.Black, 0, 0);
            string outString = "Homepage: " + outProperties.HomePage + "\n\nnumMinutesForNotify: " + outProperties.NumMinutesForNotify + "\n\nnotifyOff: " + outProperties.NotifyOff;
            g.DrawString(outString, new Font("Lucida Console", 25), Brushes.Black, 0, 50);
            return g;
        }
    }
}
