using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Rotate_Image
    {
        public void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            if (n == 1) return;
            for(int i = 0;i<n/2;i++)  //行
            {
                int com = n - i - 1;
                for(int j = i;j<com;j++)
                {
                    int temp = matrix[j, i];
                    matrix[j, i] = matrix[n - 1 - i,j];
                    matrix[ n - 1 - i,j] = matrix[n - 1 - j, n - 1 - i];
                    matrix[n - 1 - j, n - 1 - i] = matrix[i,n - 1 - j];
                    matrix[i,n - 1 - j] = temp;
                } 
            }   
        }
    }
}
