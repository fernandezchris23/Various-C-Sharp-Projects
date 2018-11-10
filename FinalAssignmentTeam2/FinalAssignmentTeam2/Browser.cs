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
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();

            menuButton.menuBttnClick += new EventHandler(menuOpen);
            homeButton.homeBttnClick += new EventHandler(homeNavigate);
        }

        private void addrBarText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser.Navigate(addrBarText.Text);
                e.Handled = true;
                e.SuppressKeyPress = true; //Shuts up the stupid 'ding' on enter
            }
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            addrBarText.Text = webBrowser.Url.ToString();
        }

        private void menuOpen(object sender, EventArgs e)
        {
            contextMenuButton.Show(menuButton, menuButton.Width - contextMenuButton.Width, menuButton.Height);
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(Properties.Settings.Default.HomePage);
        }

        private void homeNavigate(object sender, EventArgs e)
        {
            webBrowser.Navigate(Properties.Settings.Default.HomePage);
        }
    }
}
