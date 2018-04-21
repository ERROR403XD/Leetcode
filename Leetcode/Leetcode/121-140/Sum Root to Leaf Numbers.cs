using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Sum_Root_to_Leaf_Numbers
    {
        public int SumNumbers(TreeNode root)
        {
            return GetSum(root, 0);
        }
        private int GetSum(TreeNode root,int sum)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return sum*10+root.val;
            return GetSum(root.left, sum * 10 + root.val) + GetSum(root.right, sum * 10 + root.val);
        }
    }
}
