using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Path_Sum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            if (root.val == sum && (root.left == null &&root.right == null)) return true;
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (root == null) return res;
            if(root.val==sum&&root.left==null&&root.right==null)
            {
                res.Add(new List<int>() { root.val});
                return res;
            }
            List<IList<int>> leftres = (List<IList<int>>)PathSum(root.left, sum - root.val);
            List<IList<int>> rightres = (List<IList<int>>)PathSum(root.right, sum - root.val);
            foreach(IList<int>temp in leftres)
            {
                List<int> toadd = new List<int>(temp);
                toadd.Insert(0, root.val);
                res.Add(toadd);
            }
            foreach (IList<int> temp in rightres)
            {
                List<int> toadd = new List<int>(temp);
                toadd.Insert(0, root.val);
                res.Add(toadd);
            }
            return res;
        }

    }
}
