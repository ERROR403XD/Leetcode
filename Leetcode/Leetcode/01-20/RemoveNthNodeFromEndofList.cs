using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class RemoveNthNodeFromEndofList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode previous = null;
            ListNode readyToRemove = head;
            ListNode front = head;
            for(int i = 1;i<n;i++)
            {
                front = front.next;  
            }
            while(true)
            {
                if(front.next == null)
                {
                    break;
                }
                previous = readyToRemove;
                readyToRemove = readyToRemove.next;
                front = front.next; 
            }

            if(readyToRemove == head)
            {
                return head.next;
            }
            else
            {
                previous.next = readyToRemove.next;
                return head;
            }
        }
    }
}
