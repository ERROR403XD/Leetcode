using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            if (s == null || s.Length == 0) return false;

            int sourceFlag = 0;
            int targetFlag = 0;
            char targetChar;

            while(true)
            {
                targetChar = p[targetFlag];
                if(targetChar == '*')
                {
                    targetChar = p[targetFlag - 1];
                }

                if(!IsMatch(s[sourceFlag],targetChar)&&p[targetFlag]!='*')
                {
                    return false;
                }
                if(p[targetFlag] != '*')
                {
                    targetFlag++;
                    continue;
                }
                if(p[targetFlag] == '*')
                  
            }
            return true;

        }

        public bool IsMatch(char s,char t)
        {
            if(s=='.'||t == '.'||s==t)
            {
                return true;
            }
            return false;  
        }
    }
}
