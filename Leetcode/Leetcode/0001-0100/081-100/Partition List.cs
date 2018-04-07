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
            ListNode cur = head, left = null, right = null, left_s = null, right_s = null;
            while(cur!=null)
            {
                if(cur.val<x)
                {
                    if(left==null)
                    {
                        left = cur;
                        left_s = cur;
                    }
                    else
                    {
                        left.next = cur;
                        left = left.next;
                    }
                }
                else
                {
                    if(right==null)
                    {
                        right = cur;
                        right_s = cur;
                    }
                    else
                    {
                        right.next = cur;
                        right = right.next;
                    }
                }
                cur = cur.next;
            }
            if (right != null) right.next = null;
            if (left_s == null) return right_s;
            else
            {
                left.next = right_s;
                return left_s;
            }
        }
    }
}
