using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class MergeSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode head = null;
            ListNode current = null;
            if(l1.val<=l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }
            current = head;
            while(l1!=null&&l2!=null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }
            if (l1 == null) current.next = l2;
            if (l2 == null) current.next = l1;


            return head;
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            return MergeKLists(lists, 0, lists.Length - 1);
        }
        public ListNode MergeKLists(ListNode[] lists,int start,int end)
        {
            int l = end - start+1;
            if (l == 1) return lists[0];
            if (l == 2) return MergeTwoLists(lists[0], lists[1]);

            return MergeTwoLists(MergeKLists(lists, 0, l / 2-1), MergeKLists(lists, l / 2, l - 1));    
        }
    }
}
