using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Set_Matrix_Zeroes
    {
        
        public void SetZeroes(int[,] matrix)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            for(int i = 0;i<r;i++)
            {
                for(int j = 0;j<c;j++)
                {
                    if(matrix[i,j]==0)
                    {
                        rows.Add(i);
                        if (!cols.Contains(j)) cols.Add(j);
                        break;
                    }
                }
            }

            foreach(int i in rows)
            {
                for(int x = 0;x<c;x++)
                {
                    matrix[i, x] = 0;
                }
            }
            foreach(int i in cols)
            {
                for(int x = 0;x<r;x++)
                {
                    matrix[x, i] = 0;
                }
            }

        }
        
    }
}
