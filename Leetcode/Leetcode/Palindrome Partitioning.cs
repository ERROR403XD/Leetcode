using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Palindrome_Partitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            if (s.Length == 0) return new List<IList<string>>() { new List<string>()};
            if (s.Length == 1) return new List<IList<string>>() { new List<string>() {s } };
            Dictionary<string, IList<IList<string>>> dic = new Dictionary<string, IList<IList<string>>>();
            return AddPar(dic, s);
        }
        private IList<IList<string>> AddPar(Dictionary<string, IList<IList<string>>> dic, string s)
        {
            if (dic.ContainsKey(s)) return dic[s];
            if(s.Length==1)
            {
                List<IList<string>> temp = new List<IList<string>>() { new List<string>() { s } };
                dic.Add(s, temp);
                return temp;
            }
            List<IList<string>> res = new List<IList<string>>();
            if (PalinJudge(s)) res.Add(new List<string>() { s });
            for(int i = 1;i<=s.Length-1;i++)
            {
                string left_s = s.Substring(0, i);
                string right_s = s.Substring(i);

                if(PalinJudge(right_s))
                {
                    IList<IList<string>> left_list = AddPar(dic, left_s);
                    foreach(IList<string> list in left_list)
                    {
                        List<string> temp = new List<string>(list);
                        temp.Add(right_s);
                        res.Add(temp);
                    }
                }
            }
            dic.Add(s, res);
            return res;
        }
        public bool PalinJudge(string s)
        {
            if (s.Length <= 1) return true;
            for(int i =0;i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length - 1 - i]) return false;
            }
            return true;
        }

        public IList<IList<string>> PartitionII(string s)
        {
            List<IList<string>> res = new List<IList<string>>();
            List<string> one = new List<string>();
            PartitionDFS(s, 0, one, res);
            return res;
        }
        public void PartitionDFS(string s,int start,IList<string> one,IList<IList<string>> res)
        {
            if(start==s.Length)
            {
                res.Add(one);
                return;
            }
            for(int i = start;i<s.Length;i++)
            {
                if(PalinJudge(s,start,i))
                {
                    List<string> newone = new List<string>(one);
                    newone.Add(s.Substring(start, i - start + 1));
                    PartitionDFS(s, i+1, newone, res);
                }
            }
        }

        public int MinCut(string s)
        {
            if (PalinJudge(s, 0, s.Length - 1)) return 0;
            return MinCutDFS(s, 0);
        }
        private int MinCutDFS(string s,int start)
        {
            if (start == s.Length-1) return 0;
            int compare = s.Length - 1 - start;
            for(int i = start; i<s.Length; i++)
            {
                if(PalinJudge(s,start,i))
                {
                    int temp = 1 + MinCutDFS(s, i + 1);
                    if (temp < compare) compare = temp;
                }
            }
            return compare;
        }

        public int MinCutNew(string s)
        {
            if (s.Length <= 1) return 0;
            int[] cutdp = new int[s.Length];
            bool[,] dp = new bool[s.Length, s.Length];
            for(int i = s.Length-1;i>=0;i--)
            {
                cutdp[i] = s.Length - 1 - i;
                for(int j = i;j<s.Length;j++)
                {
                    if(s[i]==s[j]&&(j-i<2||dp[i+1,j-1]))
                    {
                        if (j == s.Length - 1) cutdp[i] = 0;
                        else cutdp[i] = Math.Min(cutdp[i], 1 + cutdp[j + 1]);
                        dp[i, j] = true;
                    }
                }
            }
            return cutdp[0];
        }

        public bool PalinJudge(string s, int start, int end)
        {
            if (start > end) return false;
            while (start < end)
            {
                if (s[start] != s[end]) return false;
                start++;
                end--;
            }
            return true;
        }

    }
}
