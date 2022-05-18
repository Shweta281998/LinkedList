using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class SearchInLinkedList
    {
        public bool Search(ListNode head,int key)
        {
            //Iterative approach
            ListNode current = head;
            while(current!=null)
            {
                if (current.val == key)
                    return true;
                current = current.next;
            }
            return false;
        }

        //Recursive approach
        public bool Searching(ListNode head, int key)
        {
            ListNode current = head;

            //base case
            if (current == null)
                return false;

            //if key is present in the current node
            if (current.val == key)
                return true;

            //else we can call search
            return Searching(head.next, key);

        }
    }
}
