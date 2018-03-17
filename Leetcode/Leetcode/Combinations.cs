using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> res = new List<IList<int>>();
            Stack<int> list = new Stack<int>();
            int i = 1;
            list.Push(i);
            List<int> every = new List<int>() { 1 };
            while(true)
            {
                if(list.Count < k)
                {
                    list.Push(list.Peek() + 1);
                    every.Add(list.Peek());
                }
                else if(list.Count == k)
                {
                    res.Add(new List<int>(every));
                    if(list.Peek()<n)
                    {
                        list.Push(list.Pop() + 1);
                        every[every.Count - 1] = list.Peek();
                    }
                    else
                    {
                        bool ifBreak = false;
                        while(true)
                        {
                            if(list.Peek()==n-(k-list.Count))
                            {
                                list.Pop();
                                every.RemoveAt(every.Count - 1);
                            }
                            else
                            {
                                list.Push(list.Pop() + 1);
                                every[every.Count - 1] = list.Peek();

                                break;
                            }
                            if (list.Count == 0)
                            {
                                ifBreak = true;
                                break;
                            }
                        }
                        if (ifBreak) break;
                    }
                }

            }
            return res;
        }
        /*
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (k==1)
            {
                for (int i = 1; i <= n;i++)
                {
                    List<int> temp = new List<int>() { i };
                    res.Add(temp);
                }
                return res;
            }
            IList<IList<int>> last = Combine(n, k - 1);
            foreach(IList<int> ll in last)
            {
                for(int i = ll.Last()+1;i<=n;i++)
                {
                    List<int> temp = new List<int>(ll);
                    temp.Add(i);
                    res.Add(temp);
                }
            }


            return res;
        }*/
    }
}
