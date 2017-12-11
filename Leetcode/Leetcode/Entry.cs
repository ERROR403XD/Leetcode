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
            string testString = "absd";
            string testString2 = ".*";
            int[] testArray = new int[5] { 2, 6, 7, 12, 35 };
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};

            int testInt = -2147447412;
            double pi = 3.1415926;

            Console.WriteLine(test.IsMatch(testString,testString2));

            Console.ReadKey();
        }
    }
}
