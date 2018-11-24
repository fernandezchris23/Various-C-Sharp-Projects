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
        private DoubleLinkedList backForwardList;
        private SingleLinkedList history;
        private SingleLinkedList favorites;

        private List<string> favoritesContainers;

        private bool isBackingOrForwarding; //Used to prevent hitting back or forward from clearing the rest of the list

        public Browser()
        {
            InitializeComponent();

            //Variable Initialization
            isBackingOrForwarding = false;

            //List Creation
            backForwardList = new DoubleLinkedList();
            history = new SingleLinkedList();
            favorites = new SingleLinkedList();
            favoritesContainers = new List<string>(); //Holds the names of all the containing folders in the favorites bar

            //Custom control events redirected
            menuButton.menuBttnClick += new EventHandler(menuOpen);
            homeButton.homeBttnClick += new EventHandler(homeNavigate);
            backButton.bttnClick += new EventHandler(backBttnClick);
            forwardButton.bttnClick += new EventHandler(forwardBttnClick);

            createFavoritesContextMenu();
        }

        public static Browser CreateWindow()
        {
            Browser newForm = new Browser();
            newForm.Show();
            newForm.Activate();
            return newForm;
        }

        //******BROWSER FORM EVENT HANDLERS******//

        private void addrBarText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser.Navigate(addrBarText.Text);
                e.Handled = true;
                e.SuppressKeyPress = true; //Shuts up the stupid 'ding' on enter
            }
        }

        //Handles when the webpage navigating to is finished loading
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /* Because of how webpages load, this handler will be called every time a portion of the webpage we are
             * trying to load loads, therefore we have to check the Absolute path of the URL to make sure only the URL
             * for the page we are actually trying to load is being saved into the backForwardList */
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
                return;

            addrBarText.Text = webBrowser.Url.ToString();

            if (!isBackingOrForwarding && !backForwardList.isEmpty() && !backForwardList.isLastListItem())
            {
                backForwardList.RemoveNextCascading();
            }

            if (!isBackingOrForwarding)
            {
                backForwardList.add(addrBarText.Text);
            }
            isBackingOrForwarding = false; //If we were going back or forward, we aren't anymore
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(Properties.Settings.Default.HomePage);
        }

        //*************************//

        //******CUSTOM CONTROL HANDLERS SECTION******//

        private void homeNavigate(object sender, EventArgs e)
        {
            webBrowser.Navigate(Properties.Settings.Default.HomePage);
        }

        private void menuOpen(object sender, EventArgs e)
        {
            contextMenuButton.Show(menuButton, menuButton.Width - contextMenuButton.Width, menuButton.Height);
        }

        private void backBttnClick(object sender, EventArgs e)
        {
            if (!backForwardList.isEmpty() && !backForwardList.isFirstListItem())
            {
                isBackingOrForwarding = true;
                webBrowser.Navigate(backForwardList.getPrevious());
            }
        }

        private void forwardBttnClick(object sender, EventArgs e)
        {
            if (!backForwardList.isEmpty() && !backForwardList.isLastListItem())
            {
                isBackingOrForwarding = true;
                webBrowser.Navigate(backForwardList.getNext());
            }
        }

        //*************************//

        //******MENU ITEMS HANDLER SECTION******//

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWindow();
        }

        //*************************//

        //******FAVORITES TOOLBAR SECTION******//

        private void addFavBttn_Click(object sender, EventArgs e)
        {
            AddFavoriteDialog favDlg = new AddFavoriteDialog(favoritesContainers);
            favDlg.itemDoubleClick += new EventHandler<MyEventArgs>(favDlg_DoubleClick);

            favDlg.StartPosition = FormStartPosition.CenterParent;
            favDlg.ShowDialog();
        }

        private void favDlg_DoubleClick(object sender, MyEventArgs e)
        {
            if(e.ListItemBeingPassed == "No Container")
            {
                favorites.add(addrBarText.Text);
                ToolStripButton newButton = new ToolStripButton(addrBarText.Text);
                newButton.Click += new EventHandler(favClicked);
                favToolStrip.Items.Add(newButton);
            }
            else
            {
                favorites.addToContainer(addrBarText.Text, e.ListItemBeingPassed);

            }
        }

        private void buildFavoritesBar()
        {
            SingleListNode temp = favorites.getNode();
            while (temp != null)
            {
                if(temp.isContainer)
                {
                    ToolStripDropDownButton newButton = new ToolStripDropDownButton(temp.containerName);
                    foreach(string item in temp.list)
                    {
                        newButton.DropDownItems.Add(item, null, favClicked);
                    }
                    favToolStrip.Items.Add(newButton);
                }
                else
                {
                    ToolStripButton newButton = new ToolStripButton(temp.list.First(), null, null, temp.list.First());
                    newButton.Click += new EventHandler(favClicked);
                    favToolStrip.Items.Add(newButton);
                }
                temp = temp.next;
            }
        }

        private void favClicked(object sender, EventArgs e)
        {
            ToolStripButton clickedItem = sender as ToolStripButton;
            webBrowser.Navigate(clickedItem.Text);
        }

        private void createFavoritesContextMenu()
        {
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Create Folder", new EventHandler(createFolderToolStripMenuItem_Click));

            favToolStrip.ContextMenu = contextMenu;
        }

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string contName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the folder to be created:");
            ToolStripDropDownButton newButton = new ToolStripDropDownButton(contName, null, null, contName);
            
            favToolStrip.Items.Add(newButton);

            favorites.createContainer(contName);
            favoritesContainers.Add(contName);
        }

        //*************************//
    }
}
