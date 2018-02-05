using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Merge_Intervals
    {
        /*
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            List<Interval> res = new List<Interval>();
            Dictionary<int, int> dir = new Dictionary<int, int>();
            foreach (Interval i in intervals)
            {
                if (dir.ContainsKey(i.start))
                {
                    dir[i.start]++;
                }
                else
                {
                    dir.Add(i.start, 1);
                }
                if (dir.ContainsKey(i.end))
                {
                    dir[i.end]--;
                }
                else
                {
                    dir.Add(i.end, -1);
                }   
            } 
            int[] sortedKey = new int[dir.Count];
            dir.Keys.CopyTo(sortedKey, 0);
            Array.Sort(sortedKey);

            Stack<int> temp = new Stack<int>();
            foreach (int key in sortedKey)
            {
                int curS = 0;
                if(dir[key]>0)
                {
                    for(int i = 0;i<dir[key];i++)
                    {
                        temp.Push(key);
                    }
                }
                else if(dir[key]<0)
                {
                    for (int i = 0; i < -dir[key]; i++)
                    {
                        curS = temp.Pop();
                    } 
                }
                else if(temp.Count==0)
                {
                    res.Add(new Interval(key, key));
                    continue;
                }
                if(temp.Count==0)
                {
                    res.Add(new Interval(curS, key));
                }      

            }
            return res; 
        } 
             */

        public IList<Interval> Merge(IList<Interval> intervals)
        {
            Sort(intervals);
            List<Interval> res = new List<Interval>();
            if (intervals.Count == 0) return res;
            res.Add(intervals[0]);
            for(int i = 1;i<intervals.Count;i++)
            {
                if (intervals[i].start > res.Last().end) res.Add(intervals[i]);
                else if (intervals[i].end > res.Last().end) res.Last().end = intervals[i].end;
            }
            return res;
        }

        private void Sort(IList<Interval> L)
        {
            Sort(L, 0, L.Count - 1);
        }
        private void Sort(IList<Interval> L,int s,int e)
        {
            if (e - s < 1) return;
            int pivot = new Random().Next(s, e);        
            Interval temp = L[pivot];
            L[pivot] = L[e];
            L[e] = temp;
            int comparePos = s;
            for(int p = s;p<e;p++)
            {
                if(L[p].start<L[e].start)
                {                                       
                    temp = L[p];
                    L[p] = L[comparePos];
                    L[comparePos] = temp;
                    comparePos++;   
                }
            }                                   
            temp = L[e];
            L[e] = L[comparePos];
            L[comparePos] = temp;

            Sort(L, s, comparePos - 1);
            Sort(L, comparePos + 1, e);


        }

        public void Insert(IList<Interval> given,Interval target)
        {
            bool state = false;//false :waiting for insert start,true:waiting for insert end
            for(int i =0;i<given.Count;i++)
            {
                if(!state && target.start<=given[i].start)
                {
                    state = true;
                    if(i>0&&target.start<=given[i-1].end)
                    {
                        given[i - 1].end = target.end;
                        target = given[i - 1];      
                    }
                    else
                    {
                        given.Insert(i, target);
                        i++;
                    }
                    
                }
                if (state)
                {
                    if (target.end < given[i].start) return;
                    else if (target.end <= given[i].end)
                    {
                        target.end = given[i].end;
                        given.Remove(given[i]);
                        return;
                    }
                    else
                    {
                        given.Remove(given[i]);
                        i--;
                    }
                } 
            }
            if (!state)
            {
                given.Add(target);
            }

        }

    }
}
                                                                                                                             