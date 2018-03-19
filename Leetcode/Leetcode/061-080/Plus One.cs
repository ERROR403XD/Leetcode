using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            int length = digits.Length;
            bool plus = true;
            foreach(int t in digits)
            {
                if(t!=9)
                {
                    plus = false;
                    break;
                }
            }
            if (plus) length++;
            int[] res = new int[length];
            digits[digits.Length - 1] += 1;
            for (int i = 0; i<digits.Length;i++)
            {
                res[length - 1 - i] += digits[digits.Length - 1 - i];
                if (res[length - 1 - i] >= 10)
                {
                    res[length - 1 - i] = 0;
                    res[length - 2 - i] += 1;
                }
            }

            return res;
        }
    }
}
