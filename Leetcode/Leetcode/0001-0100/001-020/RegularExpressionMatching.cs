using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class RegularExpressionMatching
    {
        private struct pair
        {
            public int i;
            public int j;
        }
        public bool IsMatch(string s, string p)
        {
            bool[,] m = new bool[s.Length+1, p.Length+1];
            List<pair> pairs = new List<pair>();
            return Dp(0, 0, s, p, m,pairs);               
        }
        private bool Dp(int i,int j,string s,string p,bool[,] m,List<pair> pairs)
        {
            bool ans;
            pair newPair;
            newPair.i = i;newPair.j = j;
            if (!pairs.Contains(newPair))
            {
                if (j == p.Length)
                {
                    ans = i == s.Length;
                }
                else
                {
                    bool firstMatch = i < s.Length && IsMatch(s[i], p[j]);
                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        ans = Dp(i, j + 2, s, p, m, pairs) || (firstMatch && Dp(i + 1, j, s, p, m, pairs));
                    }
                    else
                    {
                        ans = firstMatch && Dp(i + 1, j + 1, s, p, m, pairs);
                    }
                }
                m[i, j] = ans;
                pairs.Add(newPair);
            }
            return m[i,j];
        }
        public bool IsMatch(char s, char t)
        {
            if (s == '.' || t == '.' || s == t)
            {
                return true;
            }
            return false;
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


    }
}
