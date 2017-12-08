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
            MedianofTwoSortedArrays test = new MedianofTwoSortedArrays();
            string testString = "abba";
            int[] testArray = new int[5] { 2, 6, 7, 12, 35 };
            int[] testArrayM = new int[] {1,2};
            int[] testArrayN = new int[] {3,4};
            double pi = 3.1415926;

            double length = 2.7 * 16;
            double area = 0.002 * 0.072;
            double rate = 2.82 * Math.Pow(10, -8);
            Console.WriteLine((rate*length / area).ToString());
            //Console.WriteLine(5550000000 * ((2 * pi * pi * 0.1 * 0.01 * 0.01) - (2 * pi * pi * 0.1 * 0.007 * 0.007)));
            //Console.WriteLine(3110000000 * (pi*0.076*0.076-pi*0.074*0.074)*0.15);
            //Console.WriteLine(test.FindKth(testArray,1).ToString());          
            Console.WriteLine(test.FindMedianSortedArrays(testArrayM,testArrayN).ToString());
            Console.ReadKey();
        }
    }
}
