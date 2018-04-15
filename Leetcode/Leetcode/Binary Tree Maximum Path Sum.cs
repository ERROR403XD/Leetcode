using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Binary_Tree_Maximum_Path_Sum
    {
        public int MaxPathSum(TreeNode root)
        {
            if (root == null) return 0;
            Dictionary<TreeNode, int> maxBottomSum = new Dictionary<TreeNode, int>();
            int[] array = new int[1] { int.MinValue };
            MaxPathSum(maxBottomSum, root,array);
            return array[0];
        }
        private int SingleThrough(Dictionary<TreeNode,int> dic,TreeNode root)
        {
            if (root == null) return 0;
            if (dic.ContainsKey(root)) return dic[root];
            int dif = Math.Max(SingleThrough(dic, root.left), SingleThrough(dic, root.right));
            int res = root.val + (dif > 0 ? dif : 0);
            dic.Add(root, res);
            return res;

        }
        private int MaxPathSum(Dictionary<TreeNode,int> dic,TreeNode root)
        {
            if (root == null) return 0;
            int through = root.val + SingleThrough(dic, root.left) > 0 ? SingleThrough(dic, root.left) : 0 + SingleThrough(dic, root.right) > 0 ? SingleThrough(dic, root.right) : 0;
            if (root.left == null && root.right == null) return root.val;
            if (root.left == null) return Math.Max(MaxPathSum(dic, root.right),root.val+((SingleThrough(dic,root.right)>0)?SingleThrough(dic,root.right):0));
            if (root.right == null) return Math.Max(MaxPathSum(dic, root.left), root.val + ((SingleThrough(dic,root.left)>0) ?SingleThrough(dic,root.left):0));
            return Math.Max(root.val + ((SingleThrough(dic, root.right) > 0) ? SingleThrough(dic, root.right) : 0) + ((SingleThrough(dic, root.left) > 0) ? SingleThrough(dic, root.left) : 0), Math.Max(MaxPathSum(root.left), MaxPathSum(root.right)));
        }
        private int MaxPathSum(Dictionary<TreeNode,int> dic,TreeNode root,int[] array)
        {
            if (root == null) return 0;
            int through = root.val + (SingleThrough(dic, root.left) > 0 ? SingleThrough(dic, root.left) : 0) + (SingleThrough(dic, root.right) > 0 ? SingleThrough(dic, root.right) : 0);
            if (through > array[0]) array[0] = through;
            MaxPathSum(dic,root.left,array);
            MaxPathSum(dic,root.right,array);
            return through;
        }
    }
}
