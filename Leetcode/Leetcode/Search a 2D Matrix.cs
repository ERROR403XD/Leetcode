using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Search_a_2D_Matrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix.Length == 0) return false;
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            

            int start = 0;
            int end = r - 1;
            int select = r / 2;

            while(start<=end)
            {
                if (target < matrix[select, 0])
                {
                    end = select - 1;
                    select = (start + end) / 2;
                }
                else if(target>matrix[select,c-1])
                {
                    start = select + 1;
                    select = (start + end) / 2;
                }
                else
                {
                    break;
                }
            }
            if (start > end) return false;

            start = 0;end = c - 1;
            int s2 = c / 2;
            while(start<=end)
            {
                if(target<matrix[select,s2])
                {
                    end = s2 - 1;
                    s2 = (start + end) / 2;
                }
                else if(target>matrix[select,s2])
                {
                    start = s2 + 1;
                    s2 = (start + end) / 2;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
