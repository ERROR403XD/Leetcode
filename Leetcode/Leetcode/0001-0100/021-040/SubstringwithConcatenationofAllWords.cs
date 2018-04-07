using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Leetcode
{
    class SubstringwithConcatenationofAllWords
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> res = new List<int>();
            Dictionary<string, int> restore = new Dictionary<string, int>();
            for(int i = 0;i<words.Length;i++)
            {
                if(!restore.ContainsKey(words[i]))
                {
                    restore.Add(words[i], 1);
                }
                else
                {
                    restore[words[i]] += 1;
                }
            }

            int singleLength = words[0].Length;
            int length = words.Length * singleLength;

            for(int i = 0;i<s.Length-length+1;i++)
            {
                string temp = s.Substring(i, length);
                Dictionary<string, int> tempDic = new Dictionary<string, int>(restore);
                bool exist = true;
                for (int j = 0;j<=temp.Length-singleLength;j+=singleLength)
                {
                    string tempTemp = temp.Substring(j, singleLength);
                    
                    if(!tempDic.ContainsKey(tempTemp))
                    {
                        exist = false;
                        break;
                    }
                    else
                    {
                        int num = tempDic[tempTemp];
                        if(num==1)
                        {
                            tempDic.Remove(tempTemp);
                        }
                        else
                        {
                            tempDic[tempTemp] -= 1;
                        }

                    } 
                }
                if (!exist) continue;
                res.Add(i);      
            } 
            return res;            
        }
    }
}
