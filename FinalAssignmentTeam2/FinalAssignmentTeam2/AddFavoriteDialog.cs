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
    public partial class AddFavoriteDialog : Form
    {
        private List<string> containersInFavBar;

        public event EventHandler<MyEventArgs> itemDoubleClick;

        public AddFavoriteDialog(List<string> list)
        {
            InitializeComponent();

            containersInFavBar = list;
            createListBoxItems();
        }

        private void createListBoxItems()
        {
            foreach(string item in containersInFavBar)
            {
                listOfContainers.Items.Add(item);
            }
            listOfContainers.Items.Add("No Container");
        }

        private void listOfContainers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            itemDoubleClick(this, new MyEventArgs(listOfContainers.Text));
            this.Close();
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
