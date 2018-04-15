using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            string deal = Deal(s);
            for(int i = 0;i<=deal.Length/2;i++)
            {
                if (deal[i] != deal[deal.Length - 1 - i]) return false;
            }
            return true;
        }
        private string Deal(string s)
        {
            List<char> res = new List<char>();
            for(int i = 0;i<s.Length;i++)
            {
                if (('a' <= s[i] && s[i] <= 'z')||('0'<=s[i]&&s[i]<='9')) res.Add(s[i]);
                else if ('A' <= s[i] && s[i] <= 'Z') res.Add((char)('a'+(s[i]-'A')));
            }
            return new string(res.ToArray());
        }
    }
}
