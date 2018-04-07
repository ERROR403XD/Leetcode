using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Binary_Tree_Inorder_Traversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            InorderTraversal(root, res);
            return res;

        }
        private void InorderTraversal(TreeNode root, List<int> res)
        {
            if (root == null) return;
            if (root.left != null) InorderTraversal(root.left, res);
            res.Add(root.val);
            if (root.right != null) InorderTraversal(root.right, res);
        }
    }
}
