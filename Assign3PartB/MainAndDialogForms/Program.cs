using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAndDialogForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // if user setting is false then show login dialog
            if (Properties.Settings.Default.SkipDialog == false)
            {
                LoginDialog loginDialog = new LoginDialog();

                if (loginDialog.ShowDialog() != DialogResult.No) // if user selects yes then open application 
                    Application.Run(new MainForm());
            }
            // if user setting is true (it means they didn't want to see dialog again) then just run
            else
            {
                Application.Run(new MainForm());
            }

        }
    }
}
