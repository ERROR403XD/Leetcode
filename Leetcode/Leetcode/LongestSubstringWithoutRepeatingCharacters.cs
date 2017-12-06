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
            int areaMax_start = 0;
            int areaMax_end = 0;
            int endMax_start = 0;
            int flag;
            int endFlag = s.Length - 1;
            for(flag = 1;flag<=endFlag;flag++)
            {
                if(areaMax_end == flag-1)
                {
                    if(JudgeExist(s,s[flag],endMax_start,flag-1)==-1)
                    {
                        areaMax_end++;
                    }
                    else
                    {
                        endMax_start = FindNewEndMaxStart(s, flag);
                    }
                }
                else
                {
                    if(JudgeExist(s,s[flag],endMax_start,flag-1)==-1)
                    {
                        if((flag - endMax_start)>=(areaMax_end-areaMax_start))
                        {
                            areaMax_start = endMax_start;
                            areaMax_end = flag;   
                        }
                    }
                    else
                    {
                        endMax_start = FindNewEndMaxStart(s, flag);
                    }

                }
            }        
            return areaMax_end - areaMax_start + 1;
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
            string testString = "aaaaaaaaa";
            Console.WriteLine(test.LengthOfLongestSubstring(testString).ToString());

            Console.ReadKey();
        }
    }
}
