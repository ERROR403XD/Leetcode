using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Wildcard_Matching
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;
            for(int i = 1;i<=s.Length;i++)
            {
                dp[i, 0] = false;
            }
            for(int i = 1;i<=p.Length;i++)
            {
                if (p[i-1] == '*') dp[0, i] = dp[0, i - 1];
                else dp[0, i] = false;
            }
            for(int i = 1;i<=s.Length;i++)
            {
                for(int j = 1;j<=p.Length;j++)
                {
                    if(p[j-1]=='*')
                    {
                        dp[i, j] = dp[i - 1, j]||dp[i,j-1];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j - 1] && (p[j - 1] == '?' || p[j - 1] == s[i - 1]);
                    }
                }
            }
            return dp[s.Length, p.Length];

        }
    }
}
