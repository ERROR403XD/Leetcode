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
            bool[,] m = new bool[s.Length + 1, p.Length + 1];

            m[0, 0] = true;

            // Initiliaze m[0][j] as below loop start from i = 1
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*' && m[0, i - 1])
                {
                    m[0, i + 1] = true;
                }
            }

            for (int i = 1; i < s.Length + 1; i++)
            {
                for (int j = 1; j < p.Length + 1; j++)
                {
                    if (p[j - 1] == '.')
                    {
                        m[i, j] = m[i - 1, j - 1];
                    }

                    else if (p[j - 1] == '*')
                    {
                        m[i, j] = m[i, j - 2] || ((s[i - 1] == p[j - 2] || p[j - 2] == '.') && m[i - 1, j]);
                    }
                    else
                    {
                        m[i, j] = (m[i - 1, j - 1] && s[i - 1] == p[j - 1]);
                    }
                }
            }

            return m[s.Length, p.Length];
        }

        public bool IsMatch(string s, string p, int sStart, int pStart)
        {
            if(sStart == s.Length&&pStart==p.Length)
            {
                return true;
            }
            else if(pStart==p.Length)
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

            if (sourceFlag == s.Length)
            {
                if(p[targetFlag]=='*')
                {
                    return IsMatch(s, p, sourceFlag, targetFlag + 1);
                }
                else
                {
                    return false;
                }
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
                        return IsMatch(s, p, sourceFlag, targetFlag + 1);
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
