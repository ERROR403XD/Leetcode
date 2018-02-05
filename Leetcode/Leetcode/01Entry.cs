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

            string testString = "1234";
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
            int[] testArray = new int[] {0,2,3};
            int[] testEqual = new int[] { 1, 2, 2 };
            int[] testArrayM = new int[] { 3 };
            int[] testArrayN = new int[] { 1, 2 };
            int[,] testMat = new int[,] { {1,2,3 },{4,5,6 },{7,8,9 },{10,11,12 } };
            string[] testStringArray = new string[] { "abc", "def", "qwe" };
            string acd = "ifua";
            if(acd == "ifua")
            {
                string bbb = acd;
                char[] ca = bbb.ToCharArray();
                Array.Sort(ca);
                string sss = new string(ca);
                Console.WriteLine(sss);
            }
            
            List<int> list = new List<int>();
            list.Add(2);
            list.Remove(3);
            int testInt = -2147447412;
            ListNode head = new ListNode(1);
            ListNode end = new ListNode(2);
            head.next = end;
            
            //Interval[] testIntervals = new Interval[] {new Interval(1,3), new Interval(5, 7), new Interval(12,16), new Interval(17,21), new Interval(26, 30) };
            List<Interval> testIntervals = new List<Interval>() { new Interval(1, 3), new Interval(5, 7), new Interval(12, 16), new Interval(17, 21), new Interval(26, 30) };
            Merge_Intervals test = new Merge_Intervals();
            test.Insert(testIntervals, new Interval(6, 19));
            
            
            
            //Console.WriteLine(test.RemoveNthFromEnd(head,1));
            //Console.WriteLine(testString2.Substring(12));

            double t = 4.5, r = 0.002, a = 1.0/10000;
            double c = 0.735;
            Console.WriteLine(c-t/(((r+t/c)/(1+a))-r));
            Console.WriteLine(c / 10000);

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
