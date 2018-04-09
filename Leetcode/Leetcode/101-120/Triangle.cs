using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle == null || triangle.Count == 0) return 0;
            for(int i = 1;i<triangle.Count;i++)
            {
                for(int j = 0;j<triangle[i].Count;j++)
                {
                    if (j == 0) triangle[i][0] += triangle[i - 1][0];
                    else if (j == triangle[i].Count - 1) triangle[i][j] += triangle[i - 1][j - 1];
                    else triangle[i][j] += Math.Min(triangle[i - 1][j - 1], triangle[i - 1][j]);
                }
            }
            return triangle.Last().Min();
        }
    }
}
