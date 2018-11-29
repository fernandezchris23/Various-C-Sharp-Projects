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
        private List<string> favoritesContainers;
        private List<string> historyDatesList;

        private bool isBackingOrForwarding; //Used to prevent hitting back or forward from clearing the rest of the list
        private bool isAddingFav; //Used to prevent duplication when keeping all favorite bars synced
        private bool isMouseHoverEventSet; //Is the mouse hovering over something
        private bool isNotifyOn; //Whether or not to display notifications

        private string homePage;

        private int numMinutesToNotify;

        public Browser()
        {
            InitializeComponent();

            //Variable Initialization
            isBackingOrForwarding = false;
            isAddingFav = false;
            isMouseHoverEventSet = false;

            //List Creation
            favoritesContainers = new List<string>(); //Holds the names of all the containing folders in the favorites bar
            historyDatesList = new List<string>(); //Holds every date that history has created

            //Custom control events redirected
            menuButton.menuBttnClick += new EventHandler(menuOpen);
            homeButton.homeBttnClick += new EventHandler(homeNavigate);
            backButton.bttnClick += new EventHandler(backBttnClick);
            forwardButton.bttnClick += new EventHandler(forwardBttnClick);
            MultiSDI.Appli.favorites.listChanged += new EventHandler(favoritesChanged);
            MultiSDI.Appli.history.listChanged += new EventHandler(updateHistoryContainerNames);
            MultiSDI.Appli.settingsProperties.PropertyChanged += new PropertyChangedEventHandler(settingsChanged);

            //Initializing Methods
            createFavoritesContextMenu();
            getFavoritesContainerNames();
            getHistoryContainerNames();
            addToday();
            buildFavoritesBar();
            initializeFromSettings();
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
                ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(addrBarText.Text);
                e.Handled = true;
                e.SuppressKeyPress = true; //Shuts up the stupid 'ding' on enter
            }
        }

        private void addrBarText_Click(object sender, EventArgs e)
        {
            addrBarText.SelectAll();
        }

        //Handles when the webpage navigating to is finished loading
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /* Because of how webpages load, this handler will be called every time a portion of the webpage we are
             * trying to load loads, therefore we have to check the Absolute path of the URL to make sure only the URL
             * for the page we are actually trying to load is being saved into the backForwardList */
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
                return;

            addrBarText.Text = ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Url.ToString();

            if (!isBackingOrForwarding && !((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.isEmpty()
                                       && !((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.isLastListItem())
            {
                ((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.RemoveNextCascading();
            }

            if (!isBackingOrForwarding)
            {
                ((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.add(addrBarText.Text);
            }
            isBackingOrForwarding = false; //If we were going back or forward, we aren't anymore

            addToHistory(); //Adds URL to history

            if(!isMouseHoverEventSet)
            {
                ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Document.MouseOver += new HtmlElementEventHandler(Browser_Mouse_Move);
                isMouseHoverEventSet = true;
            }

            if(((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1 != null)
            {
                tabControl.SelectedTab.Text = ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.DocumentTitle; //Used to set Tab title
            }
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            newTabToolStripLabel_Click(this, EventArgs.Empty);
            ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(homePage);
        }

        //When the mouse moves, it checks what the mouse is hovering over and, if it is a link, it displays the URL on the status bar
        private void Browser_Mouse_Move(object sender, HtmlElementEventArgs e)
        {
            string link = ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Document.GetElementFromPoint(e.ClientMousePosition).GetAttribute("href");

            linkHoveringOvertoolStripLabel.Text = link;
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            MultiSDI.Appli.SaveState();  //Serialization
        }

        //*************************//

        //******CUSTOM CONTROL HANDLERS SECTION******//

        private void homeNavigate(object sender, EventArgs e)
        {
            ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(homePage);
        }

        private void menuOpen(object sender, EventArgs e)
        {
            contextMenuButton.Show(menuButton, menuButton.Width - contextMenuButton.Width, menuButton.Height);
        }

        private void backBttnClick(object sender, EventArgs e)
        {
            if (!((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.isEmpty() && !((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.isFirstListItem())
            {
                isBackingOrForwarding = true;
                ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.getPrevious());
            }
        }

        private void forwardBttnClick(object sender, EventArgs e)
        {
            if (!((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.isEmpty() && !((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.isLastListItem())
            {
                isBackingOrForwarding = true;
                ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(((TabComponent)tabControl.SelectedTab.Controls[0]).backForwardList.getNext());
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
            History historyForm = MakeHistoryForm(historyDatesList, MultiSDI.Appli.history);

            TabPage tab = MakeTabPage("History");
            tabControl.Controls.Add(tab);
            tab.Controls.Add(historyForm);
            historyForm.Dock = DockStyle.Fill;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm(MultiSDI.Appli.settingsProperties))
            {
                settingsForm.ShowDialog();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, addrBarText.Text);
            addrBarText.Text = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, addrBarText.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addrBarText.Text =  (string)Clipboard.GetData(DataFormats.Text);
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl.TabPages.Count < 2)
            {
                this.Close();
            }

            tabControl.TabPages.Remove(tabControl.SelectedTab);
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
            ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(clickedItem.Text);
        }

        private void favClickedDropDownItem(object sender, EventArgs e)
        {
            ToolStripDropDownItem clickedItem = sender as ToolStripDropDownItem;
            ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(clickedItem.Text);
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
            ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(e.ListItemBeingPassed);
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

        private History MakeHistoryForm(List<string> dates, SingleLinkedList history)
        {
            History historyForm = new History(dates, history);
            historyForm.itemDoubleClick += new EventHandler<StringEventArgs>(openSelectedHistoryItem);
            historyForm.clearHistoryOfDate += new EventHandler<StringEventArgs>(clearHistoryOfDate);
            historyForm.clearHistory += new EventHandler(clearHistory);

            return historyForm;
        }

        //*************************//

        //******SETTINGS SECTION******//

        private void settingsChanged(object sender, PropertyChangedEventArgs e)
        {
            isNotifyOn = MultiSDI.Appli.settingsProperties.NotifyOff;
            numMinutesToNotify = MultiSDI.Appli.settingsProperties.NumMinutesForNotify;
            homePage = MultiSDI.Appli.settingsProperties.HomePage;
        }

        private void initializeFromSettings()
        {
            isNotifyOn = MultiSDI.Appli.settingsProperties.NotifyOff;
            numMinutesToNotify = MultiSDI.Appli.settingsProperties.NumMinutesForNotify;
            homePage = MultiSDI.Appli.settingsProperties.HomePage;
        }

        //*************************//

        //******DRAG AND DROP SECTION******//

        private void Browser_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Browser_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));

            if (data != null)
            {
                ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Navigate(data);
            }
        }

        //*************************//

        //******TAB SYSTEM SECTION******//
        private void newTabToolStripLabel_Click(object sender, EventArgs e)
        {
            TabPage tab = MakeTabPage("New Tab");
            tabControl.Controls.Add(tab);

            TabComponent webTab = new TabComponent();
            tab.Controls.Add(webTab);
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.webBrowser1.DocumentCompleted += webBrowser_DocumentCompleted;
            webTab.webBrowser1.Navigate(homePage);
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(tabControl.SelectedTab.Text == "History")
            {
                return;
            }

            addrBarText.Text = ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.Url.ToString();
            tabControl.SelectedTab.Text = ((TabComponent)tabControl.SelectedTab.Controls[0]).webBrowser1.DocumentTitle;
        }

        private TabPage MakeTabPage(string text)
        {
            TabPage tab = new TabPage();
            tab.Text = text;
            return tab;
        }

        //*************************//
    }
}
