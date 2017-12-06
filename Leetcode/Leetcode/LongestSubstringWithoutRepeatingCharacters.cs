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
            int endFlag = s.Length - 1;
            int areaMax = 0;
            int endMaxStart = 0;
            for(int flag = 1;flag<=endFlag;flag++)
            {
                int tempStart = FindNewEndMaxStart(s, flag);
                if (flag - tempStart >= areaMax)
                {
                    areaMax = flag - tempStart + 1;
                    endMaxStart = tempStart;
                }      
            }
            return areaMax;  
        }
        public int FindNewEndMaxStart(string s,int flag)
        {
            if (flag == 0) return 0;
            for(int i = flag-1;i>=0;i--)
            {
                if(JudgeExist(s,s[i],i+1,flag)!=-1)
                {
                    return i + 1;
                }  
            }
            return 0;
        }
        public int JudgeExist(string s,char target,int start,int end)
        {
            for(int i = start;i <= end;i++)
            {
                if(s[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            LongestSubstringWithoutRepeatingCharacters test = new LongestSubstringWithoutRepeatingCharacters();
            string testString = "asdcghtrgfasmmhjfdf";
            Console.WriteLine(test.LengthOfLongestSubstring(testString).ToString());

            Console.ReadKey();
        }
    }
}
