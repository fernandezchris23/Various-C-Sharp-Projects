using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentTeam2
{
    class SingleListNode
    {
        public SingleListNode next { get; set; }
        public List<string> list { get; set; } //Holds list of strings
        public bool isContainer { get; set; } //Tells whether this is a container node
        public string containerName { get; set; }

        public SingleListNode()
        {
            next = null;
            list = new List<string>();
            isContainer = false;
            containerName = "";
        }
    }
    class SingleLinkedList
    {
        private SingleListNode first;
        private SingleListNode currentPosition;

        private int numNodes;

        public SingleLinkedList()
        {
            first = new SingleListNode();
            first.next = null;

            numNodes = 0;
        }

        public bool isEmpty()
        {
            return (first.next == null);
        }

        public void add(string item)
        {
            SingleListNode newNode = new SingleListNode();

            newNode.list.Add(item);
            currentPosition.next = newNode;
            newNode.next = null;
            currentPosition = currentPosition.next;
            numNodes++;
        }

        private void addToContainer(string item)
        {
            currentPosition.list.Add(item);
        }

        public void createContainer(string name)
        {
            SingleListNode newNode = new SingleListNode();

            newNode.isContainer = true;
            newNode.containerName = name;
            currentPosition.next = newNode;
            newNode.next = null;
            currentPosition = currentPosition.next;
            numNodes++;
        }

        public void removeContainer(string name)
        {
            SingleListNode temp = first.next;
            SingleListNode beforeTemp = first;

            for (int i = 0; i < numNodes; i++)
            {
                if(temp.containerName == name)
                {
                    beforeTemp.next = temp.next;
                }
                else
                {
                    beforeTemp = beforeTemp.next;
                    temp = temp.next;
                }
            }
        }

        public void removeAll()
        {
            first.next = null;
        }

        public void removeItem(string contName, string itemName)
        {
            SingleListNode temp = first.next;

            if(contName == "")
            {
                for(int i = 0; i < numNodes; i++)
                {
                    if (!temp.isContainer && temp.list.Contains(itemName))
                    {
                        temp.list.Remove(itemName);
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                return;
            }

            for (int i = 0; i < numNodes; i++)
            {
                if (temp.containerName == contName)
                {
                    temp.list.Remove(itemName);
                }
                else
                {
                    temp = temp.next;
                }
            }
        }
    }
}
