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
        private PrintStyler printStyler;

        public SettingsForm(SettingsProperties passed)
        {
            outProperties = passed;
            InitializeComponent();
            InitBindings();

            printStyler = new PrintStyler();
            printStyler.Title = "Settings";
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
            printStyler.AddPrintItem("Homepage: " + outProperties.HomePage);
            printStyler.AddPrintItem("numMinutesForNotify: " + outProperties.NumMinutesForNotify);
            printStyler.AddPrintItem("notifyOff: " + outProperties.NotifyOff);
            printStyler.PrintItems();
        }

    }
}
