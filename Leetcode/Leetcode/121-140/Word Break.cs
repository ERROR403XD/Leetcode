using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Word_Break
    {
        public bool WordBreak(string s, IList<string> wordDict)//TLE
        {
            HashSet<string> set = new HashSet<string>(wordDict);
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for(int i = 0;i<s.Length;i++)
            {
                for(int start = i;dp[i]&&start<s.Length;start++)
                {
                    if (set.Contains(s.Substring(i, start - i + 1))) dp[i + 1] = true;
                }
            }
            return dp[s.Length];
        }
        private void WordBreak(string s,HashSet<string>set,int start,string previous,List<string>res)
        {
            if (start == s.Length) res.Add(previous.Substring(1));
            for(int i = start;i<s.Length;i++)
            {
                string temp = s.Substring(start, i - start + 1);
                if(set.Contains(temp))
                {
                    string nextpre = previous + " " + temp;
                    WordBreak(s, set, i + 1, nextpre, res);
                }
            }
        }
        public IList<string> WordBreakII(string s, IList<string> wordDict)
        {
            List<string> res = new List<string>();
            HashSet<string> set = new HashSet<string>(wordDict);
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 0; i < s.Length; i++)
            {
                for (int start = i; dp[i] && start < s.Length; start++)
                {
                    if (set.Contains(s.Substring(i, start - i + 1))) dp[i + 1] = true;
                }
            }
            if (!dp[s.Length]) return res;
            WordBreak(s, set, 0, "", res);
            return res;
        }

    }
}
