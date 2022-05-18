using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    

   
        public void PrintList(ListNode head)
        {
            ListNode n = head;
            while(n!=null)
            {
                Console.WriteLine(n.val);
                n = n.next;
            }
        }

        
    }
}
