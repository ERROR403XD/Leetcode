using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Entry
    {
        static void Main(string[] args)
        {
            LongestSubstringWithoutRepeatingCharacters test = new LongestSubstringWithoutRepeatingCharacters();
            string testString = "abba";
            Console.WriteLine(test.LengthOfLongestSubstring(testString).ToString());

            Console.ReadKey();
        }
    }
}
