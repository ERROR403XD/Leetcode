using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class StringtoInteger
    {
        public int MyAtoi(string str)
        {                                       
            char[] compare = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            int[] maxCompare = new int[] { 2, 1, 4, 7, 4, 8, 3, 6, 4, 7 };

            int res = 0;
            bool findingStart = true;
            bool isNeg = false;

            for(int i = 0;i<str.Length;i++)
            {
                if (str[i] == ' '&&findingStart) continue;
                if ((str[i] == '+'||str[i]=='-')&&findingStart)
                {
                    if (str[i] == '-') isNeg = true;
                    findingStart = false;
                    continue;
                }
                if(!compare.Contains(str[i]))
                {
                    break;
                }

                findingStart = false;
                if(res> 214748364)
                {
                    return (isNeg) ? int.MinValue : int.MaxValue;
                }
                if(res == 214748364)
                {
                    if(isNeg && (int)str[i] - 48 >= 8)
                    {
                        return int.MinValue;
                    }
                    if(!isNeg && (int)str[i] - 48 >=7)
                    {
                        return int.MaxValue;
                    }
                }
                res = res * 10 + ((int)str[i] - 48);
            }
            
            return (isNeg)?-res:res;  
        }
    }
}
