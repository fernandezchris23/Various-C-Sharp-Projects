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

        private List<string> favoritesContainers;
        private List<string> historyDatesList;

        private bool isBackingOrForwarding; //Used to prevent hitting back or forward from clearing the rest of the list
        private bool isAddingFav; //Used to prevent duplication when keeping all favorite bars synced
        private bool isMouseHoverEventSet;

        public Browser()
        {
            InitializeComponent();

            //Variable Initialization
            isBackingOrForwarding = false;
            isAddingFav = false;
            isMouseHoverEventSet = false;

            //List Creation
            backForwardList = new DoubleLinkedList();
            favoritesContainers = new List<string>(); //Holds the names of all the containing folders in the favorites bar
            historyDatesList = new List<string>(); //Holds every date that history has created

            //Custom control events redirected
            menuButton.menuBttnClick += new EventHandler(menuOpen);
            homeButton.homeBttnClick += new EventHandler(homeNavigate);
            backButton.bttnClick += new EventHandler(backBttnClick);
            forwardButton.bttnClick += new EventHandler(forwardBttnClick);
            MultiSDI.Appli.favorites.listChanged += new EventHandler(favoritesChanged);
            MultiSDI.Appli.history.listChanged += new EventHandler(updateHistoryContainerNames);

            //Initializing Methods
            createFavoritesContextMenu();
            getFavoritesContainerNames();
            getHistoryContainerNames();
            addToday();
            buildFavoritesBar();
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

            addToHistory(); //Adds URL to history

            if(!isMouseHoverEventSet)
            {
                webBrowser.Document.MouseOver += new HtmlElementEventHandler(Browser_Mouse_Move);
                isMouseHoverEventSet = true;
            }
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(Properties.Settings.Default.HomePage);
        }

        //When the mouse moves, it checks what the mouse is hovering over and, if it is a link, it displays the URL on the status bar
        private void Browser_Mouse_Move(object sender, HtmlElementEventArgs e)
        {
            string link = webBrowser.Document.GetElementFromPoint(e.ClientMousePosition).GetAttribute("href");

            linkHoveringOvertoolStripLabel.Text = link;
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

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History historyForm = new History(historyDatesList, MultiSDI.Appli.history);
            historyForm.itemDoubleClick += new EventHandler<StringEventArgs>(openSelectedHistoryItem);
            historyForm.clearHistoryOfDate += new EventHandler<StringEventArgs>(clearHistoryOfDate);
            historyForm.clearHistory += new EventHandler(clearHistory);
            historyForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //*************************//

        //******FAVORITES TOOLBAR SECTION******//

        private void addFavBttn_Click(object sender, EventArgs e)
        {
            isAddingFav = true;
            AddFavoriteDialog favDlg = new AddFavoriteDialog(favoritesContainers);
            favDlg.itemDoubleClick += new EventHandler<StringEventArgs>(favDlg_DoubleClick);

            favDlg.StartPosition = FormStartPosition.CenterParent;
            favDlg.ShowDialog();
        }

        private void favDlg_DoubleClick(object sender, StringEventArgs e)
        {
            string item = addrBarText.Text;
            item = item.Replace("https", "");
            item = item.Replace("://", "");
            item = item.Replace("www.", "");

            if (e.ListItemBeingPassed == "No Container")
            {
                MultiSDI.Appli.favorites.add(addrBarText.Text);
                ToolStripButton newButton = new ToolStripButton(item, null, null, item);
                newButton.Click += new EventHandler(favClicked);
                newButton.AutoSize = false;
                newButton.Width = 100;
                newButton.TextAlign = ContentAlignment.MiddleLeft;

                if (favToolStrip.Items[item] != null)
                {
                    return;
                }
                
                favToolStrip.Items.Add(newButton);
            }
            else
            {
                MultiSDI.Appli.favorites.addToContainer(addrBarText.Text, e.ListItemBeingPassed);

                ToolStripDropDownButton temp = favToolStrip.Items[e.ListItemBeingPassed] as ToolStripDropDownButton;

                temp.DropDownItems.Add(item, null, favClickedDropDownItem);

                favToolStrip.Items.Remove(temp);
                favToolStrip.Items.Insert(2, temp);
            }
        }
        
        private void buildFavoritesBar()
        {
            if(isAddingFav)
            {
                isAddingFav = false;
                return;
            }

            SingleListNode tempNode = MultiSDI.Appli.favorites.getNode();
            while (tempNode != null)
            {
                if (!tempNode.isContainer)
                {
                    string item = tempNode.list.First();
                    item = item.Replace("https", "");
                    item = item.Replace("://", "");
                    item = item.Replace("www.", "");

                    ToolStripButton oldButton = favToolStrip.Items[item] as ToolStripButton;
                    ToolStripButton newButton = new ToolStripButton(item, null, null, item);
                    newButton.Click += new EventHandler(favClicked);
                    newButton.AutoSize = false;
                    newButton.Width = 100;
                    newButton.TextAlign = ContentAlignment.MiddleLeft;
                    favToolStrip.Items.Remove(oldButton);
                    favToolStrip.Items.Insert(2, newButton);
                }
                else
                {
                    ToolStripDropDownButton oldButton = favToolStrip.Items[tempNode.containerName] as ToolStripDropDownButton;
                    ToolStripDropDownButton newButton = new ToolStripDropDownButton(tempNode.containerName, null, null, tempNode.containerName);
                    string temp;

                    foreach(string item in tempNode.list)
                    {
                        temp = item;
                        temp = temp.Replace("https", "");
                        temp = temp.Replace("://", "");
                        temp = temp.Replace("www.", "");

                        newButton.DropDownItems.Add(temp, null, favClickedDropDownItem);
                    }

                    favToolStrip.Items.Remove(oldButton);
                    favToolStrip.Items.Insert(2, newButton);

                    if(!favoritesContainers.Contains(tempNode.containerName))
                    {
                        favoritesContainers.Add(tempNode.containerName);
                    }
                }
                tempNode = tempNode.next;
            }
        }

        private void favClicked(object sender, EventArgs e)
        {
            ToolStripButton clickedItem = sender as ToolStripButton;
            webBrowser.Navigate(clickedItem.Text);
        }

        private void favClickedDropDownItem(object sender, EventArgs e)
        {
            ToolStripDropDownItem clickedItem = sender as ToolStripDropDownItem;
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
            isAddingFav = true;

            string contName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the folder to be created:");

            if(contName == "")
            {
                MessageBox.Show("Folder Name Cannot Be Empty!");
                return;
            }

            ToolStripDropDownButton newButton = new ToolStripDropDownButton(contName, null, null, contName);
            
            favToolStrip.Items.Add(newButton);

            MultiSDI.Appli.favorites.createContainer(contName);
            favoritesContainers.Add(contName);
        }

        private void getFavoritesContainerNames()
        {
            SingleListNode temp = MultiSDI.Appli.favorites.getNode();

            favoritesContainers = MultiSDI.Appli.favorites.getContainerList();
        }

        private void favoritesChanged(object sender, EventArgs e)
        {
            buildFavoritesBar();
        }

        //*************************//

        //******HISTORY SECTION******//

        private void getHistoryContainerNames()
        {
            SingleListNode temp = MultiSDI.Appli.history.getNode();

            historyDatesList = MultiSDI.Appli.history.getContainerList();
        }

        private void updateHistoryContainerNames(object sender, EventArgs e)
        {
            historyDatesList.Clear();
            SingleListNode temp = MultiSDI.Appli.history.getNode();

            historyDatesList = MultiSDI.Appli.history.getContainerList();
        }

        //Checks if today's date has already been added to the history and if not, adds it
        private void addToday()
        {
            DateTime today = DateTime.UtcNow.Date;
            bool isAdded = historyDatesList.Contains(today.ToString("MM/dd/yyyy"));

            if(!isAdded)
            {
                historyDatesList.Add(today.ToString("MM/dd/yyyy"));
                MultiSDI.Appli.history.createContainer(today.ToString("MM/dd/yyyy"));
            }
        }

        //Using month calender controls to simplify date changed event handling
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            addToday();
        }

        private void addToHistory()
        {
            DateTime today = DateTime.UtcNow.Date;

            addToday();
            MultiSDI.Appli.history.addToContainer(addrBarText.Text, today.ToString("MM/dd/yyyy"));
        }

        private void openSelectedHistoryItem(object sender, StringEventArgs e)
        {
            webBrowser.Navigate(e.ListItemBeingPassed);
        }

        private void clearHistory(object sender, EventArgs e)
        {
            MultiSDI.Appli.history.removeAll();
            historyDatesList.RemoveRange(0, historyDatesList.Count);
            MessageBox.Show("History has been Cleared!");
        }

        private void clearHistoryOfDate(object sender, StringEventArgs e)
        {
            MultiSDI.Appli.history.removeContainer(e.ListItemBeingPassed);
            historyDatesList.Remove(e.ListItemBeingPassed);
            MessageBox.Show("History of " + e.ListItemBeingPassed + " has been erased.");
        }

        //*************************//
    }
}
