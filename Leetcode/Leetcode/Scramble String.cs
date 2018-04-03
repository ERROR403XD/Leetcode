using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Scramble_String
    {
        public bool IsScramble(string s1, string s2)
        {
            int length = s1.Length;
            if (length == 1) return true;
            int difnum = 0;
            Dictionary<char, int> check = new Dictionary<char, int>();
            for(int i = 0;i<length;i++)
            {
                if(check.ContainsKey(s1[i]))
            }
        }
    }
}
