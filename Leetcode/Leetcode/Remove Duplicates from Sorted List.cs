using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Remove_Duplicates_from_Sorted_List
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode res = head;
            ListNode last = null;
            int toCompare = head.val;
            head = head.next;

            while(head!=null)
            {
                if (head.val == toCompare)
                {
                    while(head!=null)
                    {
                        head = head.next;
                        if (head != null && head.val != toCompare) break;
                    }
                    if(last!=null)last.next = head;
                    if(res.val==toCompare)
                    {
                        res = head;
                        last = null;
                    }
                    if (head != null)
                    {
                        toCompare = head.val;
                        head = head.next;
                    }

                }
                else
                {
                    if (last == null) last = res;
                    else last = last.next;
                    toCompare = head.val;
                    head = head.next;
                }
            }
            return res;
        }

    }
}
