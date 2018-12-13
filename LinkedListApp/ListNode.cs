using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    class ListNode
    {
        //data in node
        private Object data;

        //points to next node
        private ListNode next;

        public ListNode(Object dataVal, ListNode nextNode)
        {
            data = dataVal;
            next = nextNode;
        }

        public ListNode(Object dataVal)
            :this(dataVal,null)
        {

        }

        //gets next element
        public ListNode Next
        {
            get { return next; }
            set { next = value; }
        }

        //returns the data in the node
        public Object Data
        {
            get { return data; }
        }


    }
}
