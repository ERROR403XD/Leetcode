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

            return IsMatch(s, p, 0, 0);

        }

        public bool IsMatch(string s, string p, int sStart, int pStart)
        {
            if(sStart == s.Length&&pStart==p.Length)
            {
                return true;
            }
            else if(sStart==s.Length||pStart==p.Length)
            {
                return false;
            }

            int sourceFlag = sStart;
            int targetFlag = pStart;
            char targetChar;


            targetChar = p[targetFlag];
            if(targetChar == '*')
            {
                targetChar = p[targetFlag - 1];
            }
            if (targetFlag < p.Length - 1 && p[targetFlag + 1] == '*')
            {
                targetFlag++;
            }

            if (targetChar == '.' && p[targetFlag] == '*' && targetFlag == p.Length - 1)
            {
                return true;
            }

            if (p[targetFlag] != '*')
            {
                if(!IsMatch(s[sourceFlag],targetChar))
                {
                    return false;
                }
                else
                {
                    return IsMatch(s, p, sourceFlag + 1, targetFlag + 1);
                }
            }
            else
            {
                if(IsMatch(s,p,sourceFlag,targetFlag+1))
                {
                    return true;
                }
                else
                {
                    if(IsMatch(s[sourceFlag],targetChar))
                    {
                        if (sourceFlag == s.Length-1&&targetFlag==p.Length-1)
                        {
                            return true;
                        }
                        return IsMatch(s, p, sourceFlag + 1, targetFlag);
                    }
                    else
                    {
                        return IsMatch(s, p, sourceFlag + 1, targetFlag + 1);
                    }
                }
            }
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
