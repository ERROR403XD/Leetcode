using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Rotate_List
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;
            ListNode current = head;
            ListNode end = head;
            int n = 1;
            while(end.next!=null)
            {
                end = end.next;
                n++;
            }
            end.next = head;
            k = k % n;

            end = head;
            int k2 = k;
            while(k>0)
            {
                end = end.next;
                k--;
            }
            while(end.next!=head)
            {
                end = end.next;
                current = current.next;
            }
            head = current.next;
            current.next = null; 
            return head;
        }
    }
}
