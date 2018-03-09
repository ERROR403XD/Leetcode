using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Text_Justification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> res = new List<string>();
            List<string> temp = new List<string>();
            int totalLength = 0;
            for(int i = 0;i<words.Length;i++)
            {
                if (words[i].Length > maxWidth) return null;
                if(totalLength+words[i].Length+temp.Count<=maxWidth)
                {
                    totalLength += words[i].Length;
                    temp.Add(words[i]);
                }
                else
                {
                    res.Add(ListToStr(temp,totalLength,maxWidth));
                    temp.Clear();
                    totalLength = 0;
                    i--;
                }
            }

            string lastword = "";
            for(int i = 0;i<temp.Count;i++)
            {
                lastword = lastword + temp[i];
                if (i < temp.Count - 1) lastword = lastword + " ";
            }
            if (lastword.Length < maxWidth) lastword = lastword + new string(' ', maxWidth - lastword.Length);
            res.Add(lastword);
            return res;
        }
        private string ListToStr(List<string> list,int totalLength,int maxWidth)
        {
            string res = "";
            int[] blanks = GetBlank(maxWidth - totalLength, (list.Count==1)?1:list.Count-1);
            for(int i = 0;i<list.Count;i++)
            {
                res = res + list[i];
                if (i < blanks.Length) res = res + new string(' ', blanks[i]);
            }
            return res;
        }
        private int[] GetBlank(int total,int num)
        {
            int[] res = new int[num];
            for(int i = 0;i<num;i++)
            {
                res[i] = total/num;
            }
            total = total % num;
            for(int i = 0;i<total;i++)
            {
                res[i] += 1;
            }
            return res;
        }
    }
}
