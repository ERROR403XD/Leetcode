using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Unique_Binary_Search_Trees
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            List<TreeNode> res = new List<TreeNode>();
            if (n <= 0) return res;
            if (n == 1) { res.Add(new TreeNode(1));return res; }
            List<TreeNode> N_1 = (List<TreeNode>)GenerateTrees(n - 1);
            foreach(TreeNode tree in N_1)
            {
                TreeNode temp = CopyTree(tree);
                TreeNode head = new TreeNode(n);
                head.left = temp;
                res.Add(head);
                int layers = 0;
                bool toBreak = false;
                while(!toBreak)
                {
                    TreeNode toAdd = CopyTree(tree);
                    TreeNode right = toAdd;
                    for(int i = 1;i<=layers;i++)
                    {
                        if (right != null) right = right.right;
                    }
                    if (right == null) break;
                    TreeNode t = right.right;
                    right.right = new TreeNode(n);
                    right.right.left = t;
                    res.Add(toAdd);
                    layers++;
                }
            }
            return res;
        }
        private TreeNode CopyTree(TreeNode root)
        {
            if (root == null) return null;
            TreeNode newroot = new TreeNode(root.val);
            newroot.left = CopyTree(root.left);
            newroot.right = CopyTree(root.right);
            return newroot;
        }
        public int NumTrees(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            int[] dp = new int[n+1];
            dp[0] = 1;
            dp[1] = 1;
            for(int i = 2;i<=n;i++)
            {
                int res = 0;
                for(int j = 0;j<i;j++)
                {
                    res += dp[j] * dp[i - j - 1];
                }
                dp[i] = res;
            }
            return dp[n];
        }
    }
}
