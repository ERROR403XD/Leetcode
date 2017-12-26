using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Count_and_Say
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            string last = CountAndSay(n - 1);
            string res = "";
            char compare = last[0];
            int num = 1;
            for(int i = 0;i<last.Length;i++)
            {
                if(i!=last.Length-1 && last[i+1]==last[i])
                {
                    num++;
                }
                else
                {
                    res += num.ToString();
                    res += compare;
                    if(i!=last.Length-1)
                    {
                        compare = last[i + 1];
                        num = 1;
                    }
                }
                
            }
            return res;
        }
    }
}
