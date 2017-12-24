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

            string testString = "a";
            string testString2 = "ab*b";
            int[] testArray = new int[] {2};
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};

            int testInt = -2147447412;
            ListNode head = new ListNode(1);
            ListNode end = new ListNode(2);
            head.next = end;

            LongestValidParenthesesClass test = new LongestValidParenthesesClass();
            test.LongestValidParentheses("()");
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
