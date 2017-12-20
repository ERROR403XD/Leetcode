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
            LetterCombinationsofaPhoneNumber test = new LetterCombinationsofaPhoneNumber();

            string testString = "213";
            string testString2 = "ab*b";
            int[] testArray = new int[] {0,0,0,0,0,0,1};
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};

            int testInt = -2147447412;


            Console.WriteLine(test.LetterCombinations(testString));

            Console.ReadKey();
        }



        private static double Pow(double basement,int top)
        {
            if (top == 0) return 1;
            if (top == 1) return basement;
            if (top == -1) return 1 / basement;

            return Pow(basement, top / 2) * Pow(basement, top - top / 2);   
        }
    }
}
