using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
        }
        public TreeNode BuildTree(int[] preorder, int[] inorder,int prestart,int preend,int instart,int inend)
        {
            if (instart >= inorder.Length||prestart>=preorder.Length||preend>prestart||instart>inend) return null;
            TreeNode res = new TreeNode(preorder[prestart]);
            int i = instart;
            for(i = instart;i<=inend;i++)
            {
                if (inorder[i] == preorder[prestart]) break;
            }
            res.left = BuildTree(preorder, inorder, prestart + 1, prestart + i - instart, instart, i - 1);
            res.right = BuildTree(preorder, inorder, prestart + i - instart + 1, preend, i + 1, inend);
            return res;
        }
    }
}
