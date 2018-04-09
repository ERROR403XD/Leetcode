using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Binary_Tree_Level_Order_Traversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            Add(root, res, 0);
            return res;
        }
        private void Add(TreeNode root,List<IList<int>>res,int layers)
        {
            if (root == null) return;
            if (res.Count <= layers) res.Add(new List<int>());
            res[layers].Add(root.val);
            Add(root.left, res, layers + 1);
            Add(root.right, res, layers + 1);
        }
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            AddFromBottom(root, res, 0);
            return res;
        }
        private void AddFromBottom(TreeNode root,List<IList<int>>res,int layers)
        {
            if (root == null) return;
            if (res.Count <= layers) res.Insert(0,new List<int>());
            res[res.Count - layers - 1].Add(root.val);
            AddFromBottom(root.left, res, layers + 1);
            AddFromBottom(root.right, res, layers + 1);
        }
    }
}
