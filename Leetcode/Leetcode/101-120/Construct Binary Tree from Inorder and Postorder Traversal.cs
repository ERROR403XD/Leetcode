using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return BuildTree(inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length - 1);
        }
        private TreeNode BuildTree(int[] inorder,int[]postorder,int instart,int inend,int poststart,int postend)
        {
            if (inend >= inorder.Length || postend >= postorder.Length || instart > inend || poststart > postend) return null;
            TreeNode res = new TreeNode(postorder[postend]);
            int i = 0;
            for(i = instart; i<=inend; i++)
            {
                if (inorder[i] == postorder[postend]) break;
            }
            res.left = BuildTree(inorder, postorder, instart, i - 1, poststart, poststart + i - 1 - instart);
            res.right = BuildTree(inorder, postorder, i + 1, inend, poststart + i - instart, postend - 1);
            return res;
        }
    }
}
