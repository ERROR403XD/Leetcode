using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Binary_Tree_Zigzag_Level_Order_Traversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            Add(root, res, 0, true);
            return res;
        }
        private void Add(TreeNode root, List<IList<int>> res, int layers, bool dir)
        {
            if (root == null) return;
            if (res.Count <= layers) res.Add(new List<int>());
            if (!dir) res[layers].Add(root.val);
            else res[layers].Insert(0, root.val);
            Add(root.left, res, layers + 1, !dir);
            Add(root.right, res, layers + 1, !dir);
        }
    }
}
