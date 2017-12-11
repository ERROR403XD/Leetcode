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
            if (p == null || p.Length == 0) return false;

            int sourceFlag = 0;
            int targetFlag = 0;
            char targetChar;

            while (true)
            {
                

                targetChar = p[targetFlag];
                if (targetChar == '*')
                {
                    targetChar = p[targetFlag - 1];
                }

                bool tempResult = IsMatch(s[sourceFlag], targetChar);

                if (tempResult)
                {
                    if (targetChar == '*')
                    {
                        sourceFlag++;   
                        if(sourceFlag == s.Length)
                        {
                            return true;
                        }  
                    }
                    else
                    {
                        sourceFlag++;
                        targetFlag++;   
                    }  
                     
                    if(sourceFlag == s.Length && targetFlag == p.Length)
                    {
                        return true;
                    }     
                    if(sourceFlag == s.Length || targetFlag == p.Length)
                    {
                        return false;
                    }
                }
                else
                {
                    if (targetChar == '*')
                    {                  
                        targetFlag++;
                        if(targetFlag == p.Length)
                        {
                            return false;
                        }
                        continue;
                    }
                    else
                    {
                        return false;
                    }  
                }
                  
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
