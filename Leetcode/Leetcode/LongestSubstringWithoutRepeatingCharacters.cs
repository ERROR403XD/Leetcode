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
            int length;
            for(length= s.Length; length>=2;length--)
            {
                for(int flag = 0;flag<=s.Length - length;flag++)
                {
                    if (JudgeRepeat(s, flag, flag + length - 1))
                    {
                        return length;
                    }
                }
            }
            return 1;
        }
        public bool JudgeRepeat(string s,int start,int end)
        {
            int[] chars = new int[256];
            for(int i = 0;i<chars.Length;i++)
            {
                chars[i] = 0;
            }
            for(int i = start;i<=end;i++)
            {
                if (chars[(int)(s[i])] == 1)
                {
                    return false;
                }
                else     
                {             
                    chars[(int)(s[i])] += 1;
                }   
            }      
            return true;  
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
