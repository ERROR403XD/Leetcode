using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Partition_List
    {
        public ListNode Partition(ListNode head, int x)
        {

            if (head == null) return null;
            if (head.next == null) return head;
            ListNode cur = head, more = null,more_s=null,res = head;
            while(cur.next!=null)
            {
                if(cur.next.val>=x)
                {
                    if(more==null)
                    {
                        more = cur.next;
                        more_s = more;
                    }
                    else
                    {
                        more.next = cur.next;
                        more = more.next;
                    }
                    cur.next = cur.next.next;
                }
                if (cur.next == null) break;
                else cur = cur.next;
            }
            if(head.val>=x)
            {
                res = head.next;
                cur.next = head;
                head.next = more_s;
            }
            else
            {
                cur.next = more_s;
            }

            return res;


        }
    }
}
