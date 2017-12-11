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
            LongestPalindromicSubstring test = new LongestPalindromicSubstring();
            string testString = "babad";
            int[] testArray = new int[5] { 2, 6, 7, 12, 35 };
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};
            double pi = 3.1415926;
            char[] c = new char[2];
            c[1] = 'a';
            test.LongestPalindrome(testString);
            //Console.WriteLine(5550000000 * ((2 * pi * pi * 0.1 * 0.01 * 0.01) - (2 * pi * pi * 0.1 * 0.007 * 0.007)));
            //Console.WriteLine(3110000000 * (pi*0.076*0.076-pi*0.074*0.074)*0.15);
            //Console.WriteLine(test.FindKth(testArray,1).ToString());          
            //Console.WriteLine(test.FindEqual(testArrayM,testArrayN,0,testArrayM.Length-1,testArrayM.Length,testArrayN.Length).ToString()); 
            Console.ReadKey();
        }
    }
}
