using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> res = new List<IList<int>>();
            for(int i = 1;i<=numRows;i++)
            {
                List<int> temp = new List<int>() { 1 };
                res.Add(temp);
            }
            for(int i = 1;i<numRows;i++)
            {
                for(int j = 1;j<=i;j++)
                {
                    if (j == i) res[i].Add(1);
                    else res[i].Add(res[i - 1][j] + res[i - 1][j - 1]);
                }
            }
            return res;
        }
    }
}
