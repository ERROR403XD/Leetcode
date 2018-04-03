using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Decode_Ways
    {
        public int NumDecodings(string s)
        {
            if (s.Length == 0||s[0]=='0') return 0;
            int res = 1;
            for(int i = 1;i<s.Length;i++)
            {
                if (s[i] == '0' && s[i - 1] > '2') return 0;
                if (s[i] <= '6' && s[i - 1] <= '2') res++;
            }
            return res;
            
        }
    }
}
