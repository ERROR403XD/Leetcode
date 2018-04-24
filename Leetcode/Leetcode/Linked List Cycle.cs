using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Linked_List_Cycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (head != null)
            {
                if (!set.Contains(head))
                {
                    set.Add(head);
                    head = head.next;
                }
                else return true;
            }
            return false;

        }
        public bool HasCycle_(ListNode head)
        {
            if (head == null) return false;
            ListNode slow = head, fast = head;
            while(fast!=null&&fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }
            return false;
        }
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null) return null;
            HashSet<ListNode> set = new HashSet<ListNode>();
            while(head!=null)
            {
                if (set.Contains(head)) return head;
                set.Add(head);
                head = head.next;
            }
            return null;
        }
    }
}
