using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LengthOfLinkedList
    {
        public int val;
        public ListNode next;

        public LengthOfLinkedList(int d)
        {
            val = d;
            next = null;
        }
        //iterative soln
        public int LengthLL(ListNode head)
        {
            int count = 0;
            while(head!=null)
            {
                head = head.next;
                count++;
            }
            return count;
        }

        //Recursive soln
        public int RecursiveLL(ListNode head)
        {
            int count = 0;
            if(head==null)
            {
                return 0;
            }
            return 1 + RecursiveLL(head);
        }
    }
}
