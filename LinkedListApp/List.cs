using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private String name;

        //instantiates empty list
        public List(String listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        public List()
            : this("List")
        {

        }

        public String ListName
        {
            get { return name; }
        }

        public ListNode FirstNode
        {
            get { return firstNode; }
        }

        public ListNode LastNode
        {
            get { return lastNode; }
        }

        //check to see that list is empty
        public bool IsEmpty()
        {
            if (firstNode == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //inserts data to the front of the list
        public void InsertAtFront(Object insertItem)
        {
            //if list is empty, add data to first & Last Node
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            //create new ListNode to add to front if list is not empty
            else
            {
                firstNode = new ListNode(insertItem, firstNode);
            }
        }

        //inserts data at back of list
        public void InsertAtBack(Object insertNode)
        {
            //if list is empty, add data to first & Last Node
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertNode);
            }
            //create listNode at back if List is not empty
            else
            {
                lastNode = lastNode.Next = new ListNode(insertNode);
            }
        }

        public void RemoveAtFront()
        {
            //if list is empty return error msg
            if (IsEmpty())
            {
                throw new Exception("No Data in Node");
            }

            Object removeItem = firstNode.Data;

            if (firstNode == lastNode) //if there is only first & last node, make them null
            {
                firstNode = lastNode = null;
            }
            else
            {   //make firstNode equal to the previous pointer
                firstNode = firstNode.Next;
            }
        }

        public void RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new Exception("No Data in Node");
            }
            Object removeItem = lastNode.Data;
            if (firstNode == lastNode) //if there is only first & last node, set to null
            {
                firstNode = lastNode = null;
            }
            else
            {
                //creates pointer at firstNode and iterates through list until lastNode
                ListNode currentNode = firstNode;
                while(currentNode.Next != lastNode)
                {
                    currentNode = currentNode.Next;
                }
                //at lastNode, set to null
                lastNode = currentNode;
                currentNode.Next = null;
            }
        }

        //public List<ListNode> PrintList(List nodeList)
        //{
        //   // List<ListNode> nodeList = new List<ListNode>();
        //    ListNode currentNode = nodeList.firstNode;
        //    while (currentNode.Next != lastNode)
        //    {
        //        nodeList.Add(currentNode);
        //        currentNode = currentNode.Next;
        //    }
        //    //at lastNode, set to null
        //    lastNode = currentNode;
        //    nodeList.Add(currentNode);

        //    return nodeList;

        //}

    }
}
