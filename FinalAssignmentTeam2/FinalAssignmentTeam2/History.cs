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
    public partial class History : UserControl
    {
        private List<string> dateList;

        public event EventHandler<StringEventArgs> itemDoubleClick;
        public event EventHandler<StringEventArgs> clearHistoryOfDate;
        public event EventHandler clearHistory;

        public History(List<string> dates, SingleLinkedList history)
        {
            InitializeComponent();

            dateList = dates;

            listItemsInListBox(history);
        }

        private void listItemsInListBox(SingleLinkedList history)
        {
            SingleListNode temp = history.getNode();
            
            while(temp != null)
            {
                listOfItems.Items.Add(temp.containerName);
                foreach(string item in temp.list)
                {
                    listOfItems.Items.Add(item);
                }
                temp = temp.next;
            }
        }

        private void listOfItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            itemDoubleClick(this, new StringEventArgs(listOfItems.Text));
        }

        private void clearHistoryBttn_Click(object sender, EventArgs e)
        {
            clearHistory(this, EventArgs.Empty);
        }

        private void clearDayBttn_Click(object sender, EventArgs e)
        {
            if(dateList.Contains(listOfItems.Text))
            {
                clearHistoryOfDate(this, new StringEventArgs(listOfItems.Text));
            }
            else
            {
                MessageBox.Show("Please select a date from the list before clicking the button to remove that day's history.");
            }
        }
    }
}
