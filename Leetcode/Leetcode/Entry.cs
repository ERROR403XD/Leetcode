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
            string testString = "aa";
            string testString2 = "a*";
            int[] testArray = new int[5] { 2, 6, 7, 12, 35 };
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};

            int testInt = -2147447412;
            double pi = 3.1415926;

            double rate = 1.7 * Pow(10, -8);
            double area = 2 * Pow(10, -6);

            Console.WriteLine(3.5 * 3.5 * pi);
            Console.WriteLine(71*1.001/70.999);
            Console.WriteLine(10*rate/area);

            Console.WriteLine(test.IsMatch(testString,testString2));

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
