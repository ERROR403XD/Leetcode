using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Edit_Distance
    {
        public int MinDistance(string word1, string word2)
        {
            int[,] dp = new int[word1.Length + 1, word2.Length + 1];
            dp[0, 0] = 0;
            for(int i = 1;i<=word1.Length;i++)
            {
                dp[i, 0] = i;
            }
            for (int i = 1; i <= word2.Length; i++)
            {
                dp[0, i] = i;
            }
            for(int i = 1;i<=word1.Length;i++)
            {
                for(int j = 1;j<=word2.Length;j++)
                {
                    int min = dp[i - 1, j - 1];
                    if(word1[i-1]==word2[j-1])
                    {
                        if (dp[i - 1, j] + 1 < min) min = dp[i - 1, j];
                        if (dp[i, j - 1] + 1 < min) min = dp[i, j - 1];
                    }
                    else
                    {
                        if (dp[i - 1, j] < min) min = dp[i - 1, j];
                        if (dp[i, j - 1] < min) min = dp[i, j - 1];
                        min++;
                    }
                    dp[i, j] = min;
                }
            }
            return dp[word1.Length, word2.Length];
        }
    }
}
 