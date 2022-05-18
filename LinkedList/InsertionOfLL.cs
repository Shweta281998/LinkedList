using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class InsertionOfLL
    {
        //public int head;

        //Insert new node at the beginning
        public void Push(int new_data,ListNode head)
        {
            ListNode new_node = new ListNode(new_data);
            new_node.next = head;
            head = new_node;
        }

        //Insert node in middle or after some node
        public void Push1(int new_data,ListNode head,ListNode prev_Node)
        {
            if (prev_Node == null)
            {
                Console.WriteLine("The given previous node"
                                  + " cannot be null");
                return;
            }
                ListNode new_node = new ListNode(new_data);
            
            new_node.next = prev_Node.next;

            prev_Node.next = new_node;
        }

        //Insert a node at the end
        public void Append(ListNode next_node,ListNode head, int new_data)
        {
            ListNode new_node = new ListNode(new_data);

       //     *4.If the Linked List is empty,
       //then make the new node as head* /
            if (head==null)
            {
                head = new ListNode(new_data);
                return;
            }

            /* 4. This new node is going to be
   the last node, so make next of it as null */
            new_node.next = null;

            //Else traverse till the last node

            ListNode last = null;
            while(last.next!=null)
            {
                last = last.next;

            }
            last.next = new_node;
            return;
           // Time complexity of append is O(n) where
           // n is the number of nodes in the linked list.
           // Since there is a loop from head to end, the function does O(n) work.
        }
    }
}
