using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Convert_Sorted_List_to_Binary_Search_Tree
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null) return null;
            ListNode mid = head, tail = head, pre = null;
            while(tail!=null&&tail.next!=null)
            {
                if (pre == null) pre = head;
                else pre = pre.next;
                mid = mid.next;
                tail = tail.next.next;
            }
            if (pre != null) pre.next = null;
            TreeNode root = new TreeNode(mid.val);
            if (pre == null) root.left = null;
            else root.left = SortedListToBST(head);
            root.right = SortedListToBST(mid.next);
            return root;
        }
    }
}
