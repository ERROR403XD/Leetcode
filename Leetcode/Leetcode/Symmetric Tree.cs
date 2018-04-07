using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Symmetric_Tree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return Judge(root.left, root.right);
        }
        private bool Judge(TreeNode p,TreeNode q)
        {
            if (p == null && q == null) return true;
            else if (p == null || q == null) return false;
            if (p.val != q.val) return false;
            return Judge(p.left, q.right) && Judge(p.right, q.left);
        }
    }
}
