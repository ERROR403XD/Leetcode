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

            string testString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string testString2 = "ab*b";
            int[] testArray = new int[] {4, 5, 6, 7, 0, 1, 2};
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};
            string[] testStringArray = new string[] { "abc", "def", "qwe" };

            int testInt = -2147447412;
            ListNode head = new ListNode(1);
            ListNode end = new ListNode(2);
            head.next = end;

            Search_in_Rotated_Sorted_Array test = new Search_in_Rotated_Sorted_Array();
            test.Search(testArray, 0);
            //Console.WriteLine(test.RemoveNthFromEnd(head,1));
            Console.WriteLine(testString2.Substring(12));

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
