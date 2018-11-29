using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentTeam2
{
    [Serializable()]
    public class SingleListNode : ISerializable
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

        //Used for importing data back into class
        public SingleListNode(SerializationInfo info, StreamingContext context)
        {
            next = (SingleListNode)info.GetValue("Next", next.GetType());
            list = (List<string>)info.GetValue("List", list.GetType());
            isContainer = info.GetBoolean("IsContainer");
            containerName = info.GetString("ContainerName");
        }

        //Used for exporting data to be serialized
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if(next != null)
            {
                info.AddValue("Next", next, next.GetType());
                info.AddValue("List", list, list.GetType());
                info.AddValue("IsContainer", isContainer);
                info.AddValue("ContainerName", containerName);
            }
        }
    }

    [Serializable()]
    public class SingleLinkedList : ISerializable
    {
        private SingleListNode first;
        private SingleListNode currentPosition;

        private int numNodes;
        private bool isGettingNodes;

        public event EventHandler listChanged;

        public SingleLinkedList()
        {
            first = new SingleListNode();
            first.next = null;
            currentPosition = first;

            numNodes = 0;
            isGettingNodes = false;
        }

        //Used for importing data back into class
        public SingleLinkedList(SerializationInfo info, StreamingContext context)
        {
            SingleListNode temp;
            for (int x = 0; x < info.MemberCount; ++x)
            {
                if (x == 0)
                {
                    first = (SingleListNode)info.GetValue("ListNode" + x, typeof(SingleListNode));
                    currentPosition = first;
                }
                else
                {
                    temp = (SingleListNode)info.GetValue("ListNode" + x, typeof(SingleListNode));
                    currentPosition.next = temp;
                    currentPosition = temp;
                }
            }
        }

        public bool isEmpty()
        {
            return (first.next == null);
        }

        public void add(string item)
        {
            SingleListNode newNode = new SingleListNode();

            newNode.list.Add(item);
            newNode.next = null;
            currentPosition.next = newNode;
            currentPosition = newNode;
            numNodes++;
            listChanged(null, EventArgs.Empty);
        }

        public void addToContainer(string item, string containerName)
        {
            SingleListNode temp = first.next;

            while(temp.containerName != containerName)
            {
                temp = temp.next;
            }
            temp.list.Add(item);
            listChanged(null, EventArgs.Empty);
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
            listChanged(null, EventArgs.Empty);
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
            numNodes--;
            if(numNodes == 0)
            {
                currentPosition = first;
            }
            listChanged(null, EventArgs.Empty);
        }

        public void removeAll()
        {
            first.next = null;
            numNodes = 0;
            currentPosition = first;

            listChanged(null, EventArgs.Empty);
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
            listChanged(null, EventArgs.Empty);
        }

        //Gets first node in list so Browser can get through list
        public SingleListNode getNode()
        {
            return first.next;
        }

        //Exports data to be serialized
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            int count = 0;
            SingleListNode temp = first;
            while(temp != null)
            {
                info.AddValue("ListNode" + count, temp);
                temp = temp.next;
                ++count;
            }

            Console.WriteLine(count + " items added");
        }

        public List<string> getContainerList()
        {
            SingleListNode temp = first.next;
            List<string> containerNames = new List<string>();

            while (temp != null)
            {
                if (temp.isContainer)
                {
                    containerNames.Add(temp.containerName);
                }
                temp = temp.next;
            }
            return containerNames;
        }
    }
}
