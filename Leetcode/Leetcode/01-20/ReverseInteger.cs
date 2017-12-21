using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x > -10 && x < 10) return x;
            if (x == -2147483648) return 0;
            bool isNeg = (x < 0) ? true : false;
            if (isNeg) x = -x;

            int[] compare = new int[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7 };
            int[] source = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int length = 0;

            while (true)
            {
                source[length] = x % 10;
                length++;
                if (x < 10) break;
                x /= 10;
            }
            int res = 0;
            bool danger = (length == 10) ? true : false;

            for (int i = 0; i < length; i++)
            {
                if (danger)
                {
                    if (source[i] > compare[i])
                    {
                        return 0;
                    }
                    if (source[i] < compare[i])
                    {
                        danger = false;
                    }
                }
                res += source[i] * Pow(10, length - i - 1);

            }
            return (isNeg) ? -res : res;

        }

        public int Pow(int basement, int top)
        {
            if (top == 0)
            {
                return 1;
            }
            if (top == 1)
            {
                return basement;
            }
            return Pow(basement, top / 2) * Pow(basement, top - top / 2);
        }
    }
}
