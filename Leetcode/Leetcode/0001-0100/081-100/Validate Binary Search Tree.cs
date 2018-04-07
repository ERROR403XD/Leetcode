using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Validate_Binary_Search_Tree
    {
        public bool IsValidBST(TreeNode root)
        {
            Stack<int> stack = new Stack<int>();
            return InorderJudge(stack, root);
        }
        private bool InorderJudge(Stack<int> stack,TreeNode root)
        {
            if (root == null) return true;
            if (!InorderJudge(stack, root.left)) return false;
            if (stack.Count != 0 && root.val <= stack.Pop()) return false;
            else stack.Push(root.val);
            return InorderJudge(stack, root.right);
        }
    }
}
