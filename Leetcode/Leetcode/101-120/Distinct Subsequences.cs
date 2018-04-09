using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Distinct_Subsequences
    {
        public int NumDistinct(string s, string t)
        {
            int[,] dp = new int[t.Length + 1, s.Length + 1];
            for (int i = 0; i <= s.Length; i++) dp[0, i] = 1;
            for (int i = 1; i <= t.Length; i++) dp[i, 0] = 0;
            for(int i = 1;i<=t.Length;i++)
            {
                for(int j = 1;j<=s.Length;j++)
                {
                    if(t[i-1]==s[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + dp[i, j - 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];
                    }
                }
            }
            return dp[t.Length, s.Length];

        }
    }
}
