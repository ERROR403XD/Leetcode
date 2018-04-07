using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1) return s.Length;
            int[] dp = new int[s.Length];
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int currentStart = 0;
            dp[0] = 1;
            dic.Add(s[0], 0);
            for(int flag = 1;flag<s.Length;flag++)
            {
                if(!dic.ContainsKey(s[flag]))
                {
                    dp[flag] = dp[flag - 1] + 1;
                    dic.Add(s[flag], flag);
                }
                else
                {
                    if(dic[s[flag]]<currentStart)
                    {
                        dp[flag] = dp[flag - 1] + 1;
                        dic.Remove(s[flag]);
                        dic.Add(s[flag], flag);
                    }
                    else
                    {
                        currentStart = dic[s[flag]] + 1;
                        dp[flag] = flag - dic[s[flag]];
                        dic.Remove(s[flag]);
                        dic.Add(s[flag], flag);
                    }  
                }
            }
            return dp.Max();
        }    
    }
}
