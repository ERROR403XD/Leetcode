using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LongestValidParenthesesClass
    {
        /*
        public int LongestValidParentheses(string s)
        {
            int leftNum = 0;
            bool[] res = new bool[s.Length];
            for(int i = 0;i<s.Length;i++)
            {
                if (s[i] == '(') leftNum++;
                else
                {
                    if (leftNum > 0)
                    {
                        res[i] = true;
                        leftNum--;
                    }
                }
            }
            int rightNum = 0;
            for(int i = res.Length-1;i>=0;i--)
            {
                if (res[i]) rightNum++;
                else if(rightNum>0)
                {
                    res[i] = true;
                    rightNum--;
                }   
            }
            int combo = 0;
            int max = 0;
            for(int i = 0;i<res.Length;i++)
            {
                if(res[i])
                {
                    combo++;
                    if (combo > max) max = combo;
                }
                else
                {
                    combo = 0;
                }
            }
            return max;
        }
        */
        public int LongestValidParentheses(string s)
        {
            if (s.Length <= 1) return 0;
            Stack<int> index = new Stack<int>();
            index.Push(-1);
            int max = 0;
            for(int i = 0;i<s.Length;i++)
            {
                if(s[i]=='(')
                {
                    index.Push(i);  
                }
                else
                {
                    if(index.Count!=0)
                    {
                        index.Pop();
                        if (index.Count == 0) index.Push(i);
                        max = Math.Max(max, i - index.Peek());  
                    }  
                }
            }
            return max;

        }
    }
}
