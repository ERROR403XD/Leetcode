using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Simplify_Path
    {
        public string SimplifyPath(string path)
        {
            string[] dirs = path.Split('/');

            Stack<string> stack = new Stack<string>();

            foreach(string s in dirs)
            {
                if (s == "/" || s.Length == 0 || s == ".") continue;
                else if (s == "..") { if (stack.Count != 0) stack.Pop(); }
                else stack.Push(s);
            }
            string res = "";
            if (stack.Count == 0) return "/";
            while(stack.Count!=0)
            {
                res = "/"+stack.Pop()+res;
            }
            return res;

        }
    }
}
