using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> res = new List<string>();
            if (n == 1)
            {
                res.Add("()");
                return res;
            }
            IList<string> front = GenerateParenthesis(n - 1);
            foreach(string s in front)
            {
                
                int last = s.Length - 1;
                for(;last>=0;last--)
                {
                    if (s[last] == '(') break;   
                }         
                for(;last<=s.Length-1;last++)
                {
                    res.Add(s.Substring(0, last + 1) + "()" + s.Substring(last + 1));
                }

            }  
            return res;    
        }
    }
}
