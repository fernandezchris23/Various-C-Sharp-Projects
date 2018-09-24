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

        private void skipDialogCheckbox_Click(object sender, EventArgs e)
        {
            skipDialogCheckbox.Checked = true;
        }

        private void skipDialogCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(skipDialogCheckbox.Checked == true)
                Properties.Settings.Default.SkipDialog = true;
        }

    }
}
