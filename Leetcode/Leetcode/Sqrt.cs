using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Sqrt
    {
        public int MySqrt(int x)
        {
            if (x <= 1) return x;
            double dx = (double)x;
            double x1 = 0, x2 = 1;
            while(Math.Abs(x1-x2)>0.000001)
            {
                x1 = x2;
                x2 = x1 / 2 + dx / (2 * x1);
            }
            return (int)x1;
        }
    }
}
