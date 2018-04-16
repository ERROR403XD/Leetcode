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
            for(int i = 1;i<=s.Length-1;i++)
            {
                IList<IList<string>> left = AddPar(dic, s.Substring(0, i));
                IList<IList<string>> right = AddPar(dic, s.Substring(i));
                foreach(IList<string> one_left in left)
                {
                    foreach(IList<string> one_right in right)
                    {
                        List<string> temp_res = new List<string>(one_left);
                        foreach(string temp_s in one_right)
                        {
                            temp_res.Add(temp_s);
                        }
                        res.Add(temp_res);
                    }
                }
            }
            dic.Add(s, res);
            return res;
        }
    }
}
