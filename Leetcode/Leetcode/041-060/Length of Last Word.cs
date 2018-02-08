using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            int res = 0;
            int flag = s.Length - 1;
            while(flag>=0)
            {
                if (s[flag] == ' ') flag--;
                else break;
            }
            while(flag>=0)
            {
                if (s[flag] != ' ') res++;
                else break;
                flag--;
            }
            return res;
        }
    }
}
