using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignmentTeam2
{
    public partial class SettingsForm : Form
    {
        SettingsProperties outProperties;

        public SettingsForm(SettingsProperties passed)
        {
            outProperties = passed;
            InitializeComponent();

            homePageTextBox.Text = outProperties.HomePage;
            numMinutesNotifyNumericUpDown.Value = outProperties.NumMinutesForNotify;
            if(outProperties.NotifyOff)
            {
                notifyCheckBox.Checked = true;
            }
            else
            {
                notifyCheckBox.Checked = false;
            }
            initBindings();
        }

        private void initBindings()
        {
            homePageTextBox.DataBindings.Add("Text", outProperties, "HomePage");
            numMinutesNotifyNumericUpDown.DataBindings.Add("Value", outProperties, "NumMinutesForNotify");
            notifyCheckBox.DataBindings.Add("Checked", outProperties, "NotifyOff");
        }

        private void okBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
