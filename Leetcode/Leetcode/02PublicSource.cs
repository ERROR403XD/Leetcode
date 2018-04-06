using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
 }
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public ListNode(params int[] arr)
        {
            this.val = arr[0];
            ListNode cur = this;
            for(int i = 1;i<arr.Length;i++)
            {
                cur.next = new ListNode(arr[i]);
                cur = cur.next;
            }
        }
    }
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

    class CopySource
    {
        private void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }
        private void Sort(int[] nums, int start, int end)
        {
            if (end - start < 1) return;

            int compare = nums[start];
            int comparePos = start;

            for (int flag = start + 1; flag <= end; flag++)
            {
                if (nums[flag] <= compare)
                {
                    Swap(ref nums[comparePos + 1], ref nums[flag]);
                    comparePos++;
                }
            }
            Swap(ref nums[start], ref nums[comparePos]);
            Sort(nums, start, comparePos - 1);
            Sort(nums, comparePos + 1, end);
        }
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }


}
