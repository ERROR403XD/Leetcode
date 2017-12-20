using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LetterCombinationsofaPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> res = new List<string>();
            if (digits.Length < 1) return res;
            res.Add("");
            Dictionary<char, string> digs = new Dictionary<char, string>()
            {
                { '2',"abc"},{ '3',"def"},{ '4',"ghi"},{ '5',"jkl"},{ '6',"mno"},{ '7',"pqrs"},{ '8',"tuv"},{ '9',"wxyz"},{ '0'," "}
            };          
            for(int i = 0;i<digits.Length;i++)
            {
                if (!digs.ContainsKey(digits[i])) continue;
                int rec = res.Count;   
                for(int k = 0;k<rec;k++)
                {
                    string s = res[0];
                    res.RemoveAt(0);
                    for(int j = 0;j<digs[digits[i]].Length;j++)
                    {
                        res.Add(s + digs[digits[i]][j].ToString());     
                    }
                }
            }

            return res;
        }
            /*
            public IList<string> LetterCombinations(string digits)
            {
                List<string> res = new List<string>();
                if (digits.Length < 1) return res;      
                Dictionary<char, string> digs = new Dictionary<char, string>()
                {
                    { '2',"abc"},{ '3',"def"},{ '4',"ghi"},{ '5',"jkl"},{ '6',"mno"},{ '7',"pqrs"},{ '8',"tuv"},{ '9',"wxyz"},{ '0'," "}
                };

                List<int> reference = new List<int>();
                List<int> record = new List<int>();
                for(int i = 0;i<digits.Length;i++)
                {
                    if(digs.ContainsKey(digits[i]))
                    {
                        reference.Add(digs[digits[i]].Length-1);
                    }
                    else
                    {
                        reference.Add(-1);
                    }
                    record.Add(0);
                }

                while(RefCompare(record,reference))
                {
                    string temp = "";  

                    for(int i = 0;i<record.Count;i++)
                    {
                        if(reference[i]!=-1)
                        {
                            temp += digs[digits[i]][record[i]].ToString();
                        }
                    }

                    res.Add(temp);

                    RefPlus(record, reference);
                }
                string temp2 = "";
                for (int i = 0; i < record.Count; i++)
                {
                    if (reference[i] != -1)
                    {
                        temp2 += digs[digits[i]][record[i]].ToString();
                    }
                }
                res.Add(temp2);
                return res as IList<string>;
            }   */
            private bool RefCompare(List<int> record, List<int> reference)
        {
            for(int i = 0;i<record.Count;i++)
            {
                if(reference[i]!=-1 && record[i]<reference[i])
                {
                    return true;
                }
            }
            return false;
        }
        private void RefPlus(List<int> record,List<int> reference)
        {
            for(int i = record.Count-1;i>=0;i--)
            {
                if(record[i]<reference[i])
                {
                    record[i]++;
                    return;
                }
                else if(record[i] == reference[i])
                {
                    record[i] = 0;
                }
            }
        }
    }
}
