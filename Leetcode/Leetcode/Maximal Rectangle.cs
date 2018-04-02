using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Maximal_Rectangle
    {
        public int MaximalRectangle(char[,] matrix)
        {
            if (matrix == null) return 0;
            int h = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            if (h == 0 ||n==0   )return 0;

            int res = 0;
            int[] left = new int[n];
            int[] right = new int[n];
            int[] height = new int[n];
            for(int i = 0;i<n;i++)
            {
                right[i] = n;
            }

            for(int i = 0;i<h;i++)
            {
                int cur_left = 0, cur_right = n;
                for(int j = 0;j<n;j++)
                {
                    if (matrix[i, j] == '1') height[j]++;
                    else height[j] = 0;
                }
                for(int j =0;j<n;j++)
                {
                    if (matrix[i, j] == '1') left[j] = Math.Max(left[j], cur_left);
                    else
                    {
                        left[j] = 0;
                        cur_left = j + 1;
                    }
                }
                for(int j = n-1;j>=0;j--)
                {
                    if (matrix[i, j] == '1') right[j] = Math.Min(right[j], cur_right);
                    else
                    {
                        right[j] = n;
                        cur_right = j;
                    }
                }

                for(int j = 0;j<n;j++)
                {
                    res = Math.Max(res, height[j] * (right[j] - left[j]));
                }
            }

            return res;

        }
    }
}
