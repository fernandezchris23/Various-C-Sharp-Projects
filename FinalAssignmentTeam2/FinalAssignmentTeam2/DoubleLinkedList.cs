using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used for implementing back and forward functionality

namespace FinalAssignmentTeam2
{
    public class Node
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

    public class DoubleLinkedList
    {
        private Node first;
        private Node last;
        private Node currentPosition;

        public DoubleLinkedList()
        {
            first = new Node();
            last = new Node();

            first.next = last;
            last.prev = first;

            currentPosition = null;
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

            currentPosition = newNode; //Current position will be newest node created
        }

        //Removes next item in list and all who follow it except last (Must be uppercase for some accesibility reason)
        public void RemoveNextCascading()
        {
            if(!isEmpty() && currentPosition.next != last)
            {
                currentPosition.next = last;
                last.prev = currentPosition;
            }
        }

        public bool isFirstListItem()
        {
            return (currentPosition.prev == first);
        }

        public bool isLastListItem()
        {
            return (currentPosition.next == last);
        }

        public string getPrevious()
        {
            string urlToReturn = currentPosition.prev.info; //Get the URL of the previous node to return

            currentPosition = currentPosition.prev; //Move the current position back one

            return urlToReturn; //Return the URL
        }

        public string getNext()
        {
            string urlToReturn = currentPosition.next.info; //Get the URL of the next node to return

            currentPosition = currentPosition.next; //Move the current position forward one

            return urlToReturn; //Return the URL
        }
    }
}
