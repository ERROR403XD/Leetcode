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
            RegularExpressionMatching test = new RegularExpressionMatching();
            ContainerWithMostWater test2 = new ContainerWithMostWater();
            string testString = "a";
            string testString2 = "ab*b";
            int[] testArray = new int[] {1,1};
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};

            int testInt = -2147447412;

            Console.WriteLine(test.IsMatch(testString,testString2));
            Console.WriteLine(test2.MaxArea(testArray).ToString());

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
