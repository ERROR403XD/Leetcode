using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x > -10 && x < 10) return true;
            if(x == int.MaxValue||x == int.MinValue)
            {
                return false;
            }
            if (x < 0) x = -x;
            int temp = 10;
            int length = 1;
            while(true)
            {
                if(temp>x || length>=10)
                {
                    break;
                }
                length++;
                temp *= 10;  
            }                
            for(int i = 1;i<=length/2;i++)
            {
                if(IthDig(x,i)!=IthDig(x,length+1-i))
                {
                    return false;
                }   
            }   
            return true;
        }

        public int IthDig(int source,int dig)
        {
            return (source / Pow(10, dig - 1)) % 10;
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
