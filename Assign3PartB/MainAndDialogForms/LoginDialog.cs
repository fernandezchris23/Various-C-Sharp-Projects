using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAndDialogForms
{
    public partial class LoginDialog : Form
    {

        public LoginDialog()
        {
            InitializeComponent();
        }

        // Saving the login dialog screen for future use or not into boolean in user setting
        private void skipDialogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (skipDialogCheckbox.Checked == true)
            {
                Properties.Settings.Default.SkipDialog = true; // only set it once here so no property was made
                Properties.Settings.Default.Save();
            }
        }

    }
}
