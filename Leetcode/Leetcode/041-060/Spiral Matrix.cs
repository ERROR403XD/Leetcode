using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Spiral_Matrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int num = matrix.Length;
            int i = 0, j = 0;
            int layer = 0;
            int[] res = new int[num];
            for(int k=0;k<num;k++)
            {
                res[k] = matrix[i, j];
                if (i == layer && j < n - 1 - layer) j++;
                else if (j == n - 1 - layer && i < m - 1 - layer) i++;
                else if (i == m - 1 - layer && j > layer) j--;
                else i--;
                if (i == layer && j == layer)
                {
                    layer++;
                    i = layer;
                    j = layer;
                }
                
            }
            return res;
        }
        public int[,] GenerateMatrix(int n)
        {
            int[,] res = new int[n, n];
            int length = n * n;
            int i = 0, j = 0;
            int layer = 0;
            for(int k = 0;k<length;k++)
            {
                res[i, j] = k + 1;
                if (i == layer && j < n - 1 - layer) j++;
                else if (j == n - 1 - layer && i < n - 1 - layer) i++;
                else if (i == n - 1 - layer && j > layer) j--;
                else i--;
                if(i==layer&&j==layer)
                {
                    layer++;
                    i = layer;
                    j = layer;
                }

            }
            return res;      
        }
    }
}
