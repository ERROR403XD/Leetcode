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
            ThreeSumClass test = new ThreeSumClass();
            string testString = "a";
            string testString2 = "ab*b";
            int[] testArray = new int[] {8, -15, -2, -13, 8, 5, 6, -3, -9, 3, 6, -6, 8, 14, -9, -8, -9, -6, -14, 5,
                -7, 3, -10, -14, -12, -11, 12, -15, -1, 12, 8, -8, 12, 13, -13, -3, -5, 0, 10, 2, -11, -7, 3, 4, -8,
                9, 3, -10, 11, 5, 10, 11, -7, 7, 12, -12, 3, 1, 11, 9, -9, -4, 9, -12, -6, 11, -7, 4, -4, -12, 13, -8,
                -12, 2, 3, -13, -12, -8, 14, 14, 12, 9, 10, 12, -6, -1, 8, 4, 8, 4, -1, 14, -15, -7, 9, -14, 11, 9, 5, 14};
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};

            int testInt = -2147447412;


           Console.WriteLine(test.ThreeSum(testArray));

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
