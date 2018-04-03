using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Scramble_String
    {
        public bool IsScramble(string s1, string s2)
        {
            int length = s1.Length;
            if (length == 1&&s1[0]==s2[0]) return true;
            int difnumfront = 0;
            int difnumback = 0;
            Dictionary<char, int> checkfront = new Dictionary<char, int>();
            Dictionary<char, int> checkback = new Dictionary<char, int>();
            for (int i = 0; i < length - 1; i++)
            {
                if (!checkfront.ContainsKey(s1[i])) checkfront.Add(s1[i], 0);
                if (!checkfront.ContainsKey(s2[i])) checkfront.Add(s2[i], 0);
                if (!checkback.ContainsKey(s1[i])) checkback.Add(s1[i], 0);
                if (!checkback.ContainsKey(s2[length - 1 - i])) checkback.Add(s2[length - 1 - i], 0);

                if (checkfront[s1[i]] < 0) difnumfront--;
                else difnumfront++;

                checkfront[s1[i]]++;

                if (checkfront[s2[i]] > 0) difnumfront--;
                else difnumfront++;

                checkfront[s2[i]]--;

                if (difnumfront == 0)
                {
                    if (IsScramble(s1.Substring(0, i + 1), s2.Substring(0, i + 1)) && IsScramble(s1.Substring(i + 1, length - i - 1), s2.Substring(i+1,length - i - 1))) return true;
                }

                if (checkback[s1[i]] < 0) difnumback--;
                else difnumback++;
                checkback[s1[i]]++;
                if (checkback[s2[length - 1 - i]] > 0) difnumback--;
                else difnumback++;
                checkback[s2[length - 1 - i]]--;
                if (difnumback == 0)
                {
                    if (IsScramble(s1.Substring(0, i + 1), s2.Substring(length-1-i, i + 1)) && IsScramble(s1.Substring(i+1,length-i-1), s2.Substring(0,length-i-1))) return true;
                }

            }
            return false;
        }
    }
}
