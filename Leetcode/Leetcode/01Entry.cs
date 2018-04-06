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
            int[,] matrix = new int[,] { {1,3,5,7},
                                         {10,11,16,20},
                                         {23,30,34,50},
                                            };
            char[,] testCharBoard = new char[9, 9]{{'.', '.', '9', '7', '4', '8', '.', '.', '.'},
                                                    {'7', '.', '.', '.', '.', '.', '.', '.', '.'},
                                                    {'.', '2', '.', '1', '.', '9', '.', '.', '.'},
                                                    {'.', '.', '7', '.', '.', '.', '2', '4', '.'},
                                                    {'.', '6', '4', '.', '1', '.', '5', '9', '.'},
                                                    {'.', '9', '8', '.', '.', '.', '3', '.', '.'},
                                                    {'.', '.', '.', '8', '.', '3', '.', '2', '.'},
                                                    {'.', '.', '.', '.', '.', '.', '.', '.', '6'},
                                                    {'.', '.', '.', '2', '7', '5', '9', '.', '.'}};
            int[] testArray = new int[] {1,2,2};
            int[] testEqual = new int[] { 1, 2, 2 };
            int[] testArrayM = new int[] { 1};
            int[] testArrayN = new int[] {  };
            int[,] testMat = new int[,] { {1,2,3 },{4,5,6 },{7,8,9 },{10,11,12 } };
            string[] testStringArray = new string[] { "abc", "def", "qwe" };
            int[,] path = new int[1, 1] { { 1} };
            
            List<int> list = new List<int>();
            list.Add(2);
            list.Remove(3);
            int testInt = -2147447412;
            /*
            ListNode head = new ListNode(1);
            ListNode end1 = new ListNode(4);
            ListNode end2 = new ListNode(3);
            ListNode end3 = new ListNode(2);
            ListNode end4 = new ListNode(5);
            ListNode end5 = new ListNode(3);
            ListNode end6 = new ListNode(4);
            head.next = end1;
            end1.next = end2;
            end2.next = end3;
            end3.next = end4;
            end4.next = end5;
            end5.next = end6;
            */
            ListNode head2 = new ListNode(3,5);

            //Interval[] testIntervals = new Interval[] {new Interval(1,3), new Interval(5, 7), new Interval(12,16), new Interval(17,21), new Interval(26, 30) };
            List<Interval> testIntervals = new List<Interval>() { new Interval(1, 2), new Interval(3, 5), new Interval(6, 7), new Interval(8, 10), new Interval(12, 16) };
            string[] testStrs = new string[] { "What", "must", "be", "shall", "be."};

            Restore_IP_Addresses test = new Restore_IP_Addresses();
            test.RestoreIpAddresses("12312");

            
            
            
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
