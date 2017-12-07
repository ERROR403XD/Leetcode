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
            int[] testArrayN = new int[] {1,2,3};
            double pi = 3.1415926;
            Console.WriteLine(5550000000 * ((2 * pi * pi * 0.1 * 0.01 * 0.01) - (2 * pi * pi * 0.1 * 0.007 * 0.007)));
            Console.WriteLine(3110000000 * (pi*0.076*0.076-pi*0.074*0.074)*0.15);
            //Console.WriteLine(test.FindKth(testArray,1).ToString());          
            //Console.WriteLine(test.FindMedianSortedArrays(testArrayM,testArrayN).ToString());
            Console.ReadKey();
        }
    }
}
