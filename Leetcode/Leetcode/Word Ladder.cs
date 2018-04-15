using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Word_Ladder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> set = new HashSet<string>(wordList);
            if (set.Contains(beginWord)) set.Remove(beginWord);
            Queue<string> queue = new Queue<string>();
            int level = 1;
            int curnum = 1, nexnum = 0;
            queue.Enqueue(beginWord);
            while(queue.Count!=0)
            {
                string word = queue.Dequeue();
                curnum--;
                for(int i = 0;i<word.Length;i++)
                {
                    char[] wordunit = word.ToCharArray();
                    for(char j = 'a';j<='z';j++)
                    {
                        wordunit[i] = j;
                        string temp = new string(wordunit);

                        if(set.Contains(temp))
                        {
                            if (temp == endWord) return level + 1;
                            nexnum++;
                            queue.Enqueue(temp);
                            set.Remove(temp);
                        }
                    }
                }
                if(curnum==0)
                {
                    curnum = nexnum;
                    nexnum = 0;
                    level++;
                }
            }
            return 0;
        }
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> set = new HashSet<string>(wordList);
            if (set.Contains(beginWord)) set.Remove(beginWord);
            if (!set.Contains(endWord)) return new List<IList<string>>();
            List<List<MultiLink<string>>> bfs = new List<List<MultiLink<string>>>();
            bfs.Add(new List<MultiLink<string>>());
            bfs[0].Add(new MultiLink<string>(beginWord));
            Dictionary<string, int> curentlevel = new Dictionary<string, int>();
            bool tobreak = false;
            while(set.Count!=0)
            {
                int recordSetCount = set.Count;
                bfs.Add(new List<MultiLink<string>>());
                foreach(MultiLink<string> mltemp in bfs[bfs.Count-2])
                {
                    string word = mltemp.val;
                    for(int i = 0;i<word.Length;i++)
                    {
                        char[] wordunit = word.ToCharArray();
                        for(char j = 'a';j<='z';j++)
                        {
                            wordunit[i] = j;
                            string tempstr = new string(wordunit);
                            if(set.Contains(tempstr))
                            {
                                if(!curentlevel.ContainsKey(tempstr))
                                {
                                    curentlevel.Add(tempstr, bfs.Last().Count);
                                    bfs.Last().Add(new MultiLink<string>(tempstr));
                                }
                                bfs.Last()[curentlevel[tempstr]].AddPre(mltemp);
                                if (tempstr == endWord) tobreak = true;
                            }
                        }
                    }
                }
                if (tobreak) break;
                foreach(string toRemove in curentlevel.Keys)
                {
                    set.Remove(toRemove);
                }
                if(set.Count==recordSetCount) return new List<IList<string>>(); 
                curentlevel.Clear();

            }
            MultiLink<string> start = bfs.Last()[curentlevel[endWord]];
            return GetRes(start);
        }
        private List<IList<string>> GetRes(MultiLink<string> start)
        {
            List<IList<string>> res = new List<IList<string>>();
            if(start.pre.Count==0)
            {
                res.Add(new List<string>());
                res[0].Add(start.val);
                return res;
            }
            foreach(MultiLink<string>temp in start.pre)
            {
                List<IList<string>> last = GetRes(temp);
                foreach(IList<string> templist in last)
                {
                    List<string> toadd = new List<string>(templist);
                    toadd.Add(start.val);
                    res.Add(toadd);
                }
            }
            return res;
        }

    }
    class MultiLink<T>
    {
        public T val;
        public List<MultiLink<T>> pre;
        public MultiLink(T s)
        {
            val = s;
            pre = new List<MultiLink<T>>();
        }
        public void AddPre(MultiLink<T> newpre)
        {
            pre.Add(newpre);
        }
    }
}
