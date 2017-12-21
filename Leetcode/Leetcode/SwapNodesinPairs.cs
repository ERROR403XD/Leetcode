using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class SwapNodesinPairs
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
    }
}
