using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //test in java
    class Populating_Next_Right_Pointers_in_Each_Node
    {
        public void connect(TreeLinkNode root)
        {
            if (root == null) return;
            if (root.left != null) root.left.next = root.right;
            if (root.right != null) root.right.next = (root.next == null) ? null : root.next.left;
            connect(root.next);
            connect(root.left);
        }
        public void connectII(TreeLinkNode root)
        {
            if (root == null) return;
            if (root.left == null && root.right == null) return;
            if(root.left==null)
            {
                root.right.next = getNext(root.next);
            }
            else if(root.right==null)
            {
                root.left.next = getNext(root.next);
            }
            else
            {
                root.left.next = root.right;
                root.right.next = getNext(root.next);
            }
            connectII(root.right);
            connectII(root.left);
        }
        public TreeLinkNode getNext(TreeLinkNode root)
        {
            if (root == null) return null;
            if (root.left != null) return root.left;
            if (root.right != null) return root.right;
            if (root.next != null) return getNext(root.next);
            return null;
        }
    }
}
