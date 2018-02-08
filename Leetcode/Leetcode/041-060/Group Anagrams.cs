using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Group_Anagrams
    {
        /* 超时
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> res = new List<IList<string>>();
            if (strs == null || strs.Length == 0) return res;
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            foreach(string s in strs)
            {
                string key = null;
                foreach(string k in dic.Keys)
                {
                    if(CompareString(k,s))
                    {
                        key = k;
                        break;    
                    } 
                }
                if(key == null)
                {
                    key = s;
                    dic.Add(key, new List<string>());
                }
                dic[key].Add(s);
            }
            foreach(List<string> s in dic.Values)
            {
                res.Add(s);
            }
            return res;
        }
        public bool CompareString(string s,string p)
        {
            if (s.Length != p.Length) return false;
            Dictionary<char, int> restore = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if (!restore.ContainsKey(c)) restore.Add(c, 1);
                else restore[c] += 1;  
            }
            foreach(char c in p)
            {
                if (!restore.ContainsKey(c) || restore[c] == 0) return false;
                else restore[c] -= 1;
            }
            return true;
        } 
             
             */
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> res = new List<IList<string>>();
            if (strs == null || strs.Length == 0) return res;
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            foreach(string s in strs)
            {
                string key = StrSort(s);
                if(!dic.ContainsKey(key))
                {
                    dic.Add(key, new List<string>());
                }
                dic[key].Add(s);
            }
            foreach (List<string> s in dic.Values)
            {
                res.Add(s);
            }
            return res;
        }
        public string StrSort(string s)
        {
            char[] c = s.ToCharArray();
            Array.Sort(c);
            return new string(c);
        }
    }
}
