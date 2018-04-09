using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Flatten_Binary_Tree_to_Linked_List
    {
        public void Flatten(TreeNode root)
        {
            Flat(root);
        }
        private TreeNode Flat(TreeNode root)
        {
            if (root == null ) return null;
            if (root.left == null && root.right == null) return root;
            if(root.left==null)
            {
                return Flat(root.right);
            }
            if(root.right==null)
            {
                root.right = root.left;
                root.left = null;
                return Flat(root.right);
            }
            TreeNode right = root.right;
            TreeNode res = Flat(right);
            root.right = root.left;
            root.left = null;
            Flat(root.right).right = right;
            return res;
        }
    }
}
