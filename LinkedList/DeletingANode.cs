using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class DeletingANode
    {
        public void delete(ListNode head,int key)
        {

            ListNode temp = head, prev = null;
           // If head node itself holds
            // the key to be deleted
            if (temp != null && temp.val==key)
            {
                //changed head
                head = temp.next;
                return;
            }

            // Search for the key to be
            // deleted, keep track of the
            // previous node as we need
            // to change temp.next

            while(temp!=null && temp.val!=key)
            {
                prev = temp;
                temp = temp.next;
            }

            // If key was not present
            // in linked list

            if (temp == null)
                return;

            // Unlink the node from linked list
            prev.next = temp.next;
        }
    }
}
