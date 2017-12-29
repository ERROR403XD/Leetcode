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
            char[,] testCharBoard = new char[9, 9]{{'.', '.', '9', '7', '4', '8', '.', '.', '.'},
                                                    {'7', '.', '.', '.', '.', '.', '.', '.', '.'},
                                                    {'.', '2', '.', '1', '.', '9', '.', '.', '.'},
                                                    {'.', '.', '7', '.', '.', '.', '2', '4', '.'},
                                                    {'.', '6', '4', '.', '1', '.', '5', '9', '.'},
                                                    {'.', '9', '8', '.', '.', '.', '3', '.', '.'},
                                                    {'.', '.', '.', '8', '.', '3', '.', '2', '.'},
                                                    {'.', '.', '.', '.', '.', '.', '.', '.', '6'},
                                                    {'.', '.', '.', '2', '7', '5', '9', '.', '.'}};
            int[] testArray = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int[] testArrayM = new int[] {3};
            int[] testArrayN = new int[] {1,2};
            string[] testStringArray = new string[] { "abc", "def", "qwe" };

            List<int> list = new List<int>();
            list.Add(2);
            list.Remove(3);
            int testInt = -2147447412;
            ListNode head = new ListNode(1);
            ListNode end = new ListNode(2);
            head.next = end;

            Trapping_Rain_Water test = new Trapping_Rain_Water();
            test.Trap(testArray);
            //Console.WriteLine(test.RemoveNthFromEnd(head,1));
            //Console.WriteLine(testString2.Substring(12));

            double t = 0.5, r = 0.005, a = 0.0001;
            double c = 0.01;
            Console.WriteLine(t / ((r + t / c) / (1 + a) - r));

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
