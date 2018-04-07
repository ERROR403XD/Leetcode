using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Decode_Ways
    {
        public int NumDecodings(string s)
        {
            if (s.Length == 0||s[0]=='0') return 0;
            if (s.Length == 1) return 1;
            int[] dp = new int[s.Length];
            dp[0] = 1;
            if (s[1] == '0' && s[0] > '2') return 0;
            if (s[1] == '0') dp[1] = 1;
            else if (s[0] > '2') dp[1] = 1;
            else if (s[0] == '2' && s[1] > '6') dp[1] = 1;
            else dp[1] = 2;
            
            for(int i = 2;i<s.Length;i++)
            {
                if (s[i - 1] == '0')
                {
                    if (s[i] == '0') return 0;
                    else dp[i] = dp[i - 1];
                }
                else if(s[i-1]<'2')
                {
                    if (s[i] == '0') dp[i] = dp[i - 2];
                    else dp[i] = dp[i - 1] + dp[i - 2];
                }
                else if(s[i-1]=='2')
                {
                    if (s[i] == '0') dp[i] = dp[i - 2];
                    else if (s[i] <= '6') dp[i] = dp[i - 1] + dp[i - 2];
                    else dp[i] = dp[i - 1];
                }
                else
                {
                    if (s[i] == '0') return 0;
                    else dp[i] = dp[i - 1];
                }
            }
            return dp[s.Length - 1];
        }
    }
}
