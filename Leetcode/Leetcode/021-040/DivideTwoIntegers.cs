using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if(divisor==1)
            {
                return dividend;
            }
            if(divisor == 0||(dividend==int.MinValue&&divisor==-1))
            {
                return int.MaxValue;
            }
            int sign = ((dividend < 0) ^ (divisor < 0)) ? -1 : 1;
            long dvd = Math.Abs((long)dividend);
            long dvs = Math.Abs((long)divisor);
            long res = 0;
            while(dvd>=dvs)
            {
                long temp = dvs ;
                long multiple = 1;
                while(dvd>=(temp<<1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }
                dvd -= temp;
                res += multiple;
            }
            return (sign == 1) ? (int)res : (int)-res;    
        }
    }
}
