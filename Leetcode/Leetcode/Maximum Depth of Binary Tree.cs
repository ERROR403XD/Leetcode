﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Maximum_Depth_of_Binary_Tree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            else return Math.Max(MaxDepth(root.left),MaxDepth(root.right))+1;
        }
        
    }
}
