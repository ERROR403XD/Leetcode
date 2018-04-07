using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Recover_Binary_Search_Tree
    {
        public void RecoverTree(TreeNode root)
        {
            List<TreeNode> res = new List<TreeNode>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            InorderSearch(res, root, stack);
            int temp = res[0].val;
            res[0].val = res.Last().val;
            res.Last().val = temp;

        }
        public void InorderSearch(List<TreeNode> res,TreeNode root,Stack<TreeNode>stack)
        {
            if (root == null) return;
            InorderSearch(res,root.left,stack);
            if(stack.Count!=0&&root.val<stack.Peek().val)
            {
                res.Add(stack.Pop());
                stack.Push(root);
                res.Add(root);
            }
            else
            {
                if (stack.Count != 0) stack.Pop();
                stack.Push(root);
            }
            InorderSearch(res, root.right, stack);
        }
    }
}
