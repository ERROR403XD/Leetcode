using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class SwapNodes
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;
            ListNode first = head;
            ListNode second = head.next;
            if (second == null) return head;
            ListNode front = second.next;
            second.next = first;
            first.next = SwapPairs(front);
            return second;
        }
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null) return null;
            if (k == 1) return head;
            ListNode front = head;
            for(int i = 1;i<=k-1;i++)
            {
                if (front.next == null) return head;
                front = front.next;
            }
            front = front.next;

            ListNode current = head;
            ListNode next = current.next;
            ListNode temp = next.next;
            for (int i = 1;i<=k-1;i++)
            {
                next.next = current;
                current = next;
                next = temp;
                if(temp!=null)temp = temp.next;   
            }
            head.next = ReverseKGroup(front, k);
            return current;
        }
    }
}
