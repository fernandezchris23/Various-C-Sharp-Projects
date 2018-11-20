using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used for implementing back and forward functionality

namespace FinalAssignmentTeam2
{
    class Node
    {
        public string info { get; set; } //Holds url
        public Node next { get; set; }
        public Node prev { get; set; }

        public Node()
        {
            info = "";
            next = null;
            prev = null;
        }
    }

    class DoubleLinkedList
    {
        private Node first;
        private Node last;

        public DoubleLinkedList()
        {
            first = new Node();
            last = new Node();

            first.next = last;
            last.prev = first;
        }

        public bool isEmpty()
        {
            return (first.next == last);
        }

        public void add(string url)
        {
            Node newNode = new Node();

            newNode.info = url;
            newNode.prev = (last.prev);
            newNode.next = last;

            if(isEmpty())
            {
                first.next = newNode; //If first wasn't pointing to a new node, now it will
            }
            else
            {
                last.prev.next = newNode; //get the node that last was originally pointing to and set its next to the new node
            }

            last.prev = newNode; //Last should point to new node because it is at end of list
        }

        //Removes next item in list and all who follow it except last (Must be uppercase for some accesibility reason)
        public void RemoveNextCascading(Node current)
        {
            if(!isEmpty() && current.next != last)
            {
                current.next = last;
                last.prev = current;
            }
        }

        public bool isLastListItem(Node current)
        {
            return (current.next == last);
        }
    }
}
