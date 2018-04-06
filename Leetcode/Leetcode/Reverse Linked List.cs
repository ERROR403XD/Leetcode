using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Reverse_Linked_List
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m == n) return head;
            int flag = 1;
            ListNode res = head,pre = null, start = null,cur = null,end = null, rest = null;
            while(head!=null)
            {
                ListNode temp = head.next;
                if(flag == m-1)
                {
                    pre = head;
                }
                if(flag == m)
                {
                    start = head;
                    cur = head;
                    cur.next = null;
                }
                if(m<flag&&flag<n)
                {
                    head.next = cur;
                    cur = head;
                }
                if(flag==n)
                {
                    end = head;
                    start.next = head.next;
                    head.next = cur;
                    if(pre!=null)pre.next = head;
                    break;

                }

                head = temp;
                flag++;
            }
            if (pre == null) return end;
            else return res;
        }
    }
}
