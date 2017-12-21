using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ValidParentheses
    {
        /*
        public bool IsValid(string s)
        {
            if (s.Length == 1) return false;
            if (s.Length == 0) return true;
            int[] record = new int[3] { 0, 0, 0};
            Dictionary<char, int> restore = new Dictionary<char, int>()
            {
                {'(',1},{'[',2},{'{',3},{')',-1},{']',-2},{'}',-3}
            };

            if (restore[s[0]]<0) return false;

            int startDig = restore[s[0]] - 1;
            int i;
            for(i = 0;i<s.Length;i++)
            {
                int dig = Math.Abs(restore[s[i]]) - 1;
                record[dig] += restore[s[i]];
                if (record[dig] < 0) return false;
                if (record[startDig] == 0) break; 
            }
            if (record[0] == 0 && record[1] == 0 && record[2] == 0) return IsValid(s.Substring(i+1));
            else return false;
        } */
        public bool IsValid(string s)
        {
            Stack<char> restore = new Stack<char>();
            foreach(char c in s)
            {
                switch(c)
                {
                    case '(':
                    case '[':
                    case '{':
                        {
                            restore.Push(c);
                            break;
                        }
                    case ')':
                        {
                            if (restore.Count == 0 || restore.Peek() != '(') return false;
                            else restore.Pop();
                            break;
                        }
                    case ']':
                        {
                            if (restore.Count == 0 || restore.Peek() != '[') return false;
                            else restore.Pop();
                            break;
                        }
                    case '}':
                        {
                            if (restore.Count == 0 || restore.Peek() != '{') return false;
                            else restore.Pop();
                            break;
                        }
                }
            }
            return restore.Count == 0;
        }
    }
}
