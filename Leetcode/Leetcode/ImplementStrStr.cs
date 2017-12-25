using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            int res = 0;
            for (; res < haystack.Length - needle.Length + 1; res++)
            {
                if(needle == haystack.Substring(res,needle.Length))
                {
                    return res;
                }  
            }
            return-1;
        }
        
    }
}
