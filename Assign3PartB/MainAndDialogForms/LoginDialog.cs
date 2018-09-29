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
        
        // Saving the login dialog screen for future use or not into boolean into SkipDialog user setting
        private void skipDialogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (skipDialogCheckbox.Checked == true)
            {
                // only set it once here so no property was made
                Properties.Settings.Default.SkipDialog = true;  // when user checks checkbox they do not want to see login dialog
                Properties.Settings.Default.Save();             // save user setting
            }
        }

    }
}
