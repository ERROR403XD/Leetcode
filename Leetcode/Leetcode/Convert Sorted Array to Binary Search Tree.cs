using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Convert_Sorted_Array_to_Binary_Search_Tree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }
        private TreeNode SortedArrayToBST(int[]nums,int start,int end)
        {
            if (start > end) return null;
            int i = (start + end) / 2;
            TreeNode root = new TreeNode(nums[i]);
            root.left = SortedArrayToBST(nums, start, i - 1);
            root.right = SortedArrayToBST(nums, i + 1, end);
            return root;
        }
    }
}
