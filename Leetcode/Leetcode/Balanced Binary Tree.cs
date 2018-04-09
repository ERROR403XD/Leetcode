using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Balanced_Binary_Tree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (Depth(root) == -1) return false;
            else return true;
        }
        private int Depth(TreeNode root)
        {
            if (root == null) return 0;
            int left = Depth(root.left);
            int right = Depth(root.right);
            int dif = left - right;
            if (right != -1 && left != -1 && dif >= -1 && dif <= 1) return Math.Max(left, right)+1;
            else return -1;
        }
    }
}
