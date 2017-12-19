using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class RomeNumber
    {
        public string IntToRoman(int num)
        {
            string res = "";

            string[] digs = {"I","V","X","L","C","D","M"};
            int dig = 1;
            int currentNum;
            while(true)
            {
                currentNum = num % 10;
                num /= 10;

                string current = "";
                if(currentNum<=3)
                {
                    for (int i = 0; i < currentNum; i++) current += digs[dig - 1];  
                }
                else if(currentNum == 4)
                {
                    current = digs[dig - 1] + digs[dig];
                }
                else if(currentNum <= 8)
                {
                    current = digs[dig];
                    for (int i = 0; i < currentNum-5; i++) current += digs[dig - 1];
                }
                else if (currentNum == 9)
                {
                    current = digs[dig - 1] + digs[dig + 1];
                }
                res = current + res; ;
                dig+=2;
                if (num == 0) break;  
            }

            return res;
        }
        public int RomanToInt(string s)
        {
            
            Dictionary<char, int> digs = new Dictionary<char, int>()
            {
                {'I',1 },{'V',5 },{'X',10 },{'L',50 },{'C',100 },{'D',500 },{'M',1000 }
            };

            if(s.Length == 1)
            {
                return digs[s[0]];
            }
            int res = digs[s[s.Length-1]];
            for (int i = s.Length-2;i>=0;i--)
            {
                if(digs[s[i]]>=digs[s[i+1]])
                {
                    res += digs[s[i]];
                }
                else
                {
                    res -= digs[s[i]];
                }

            }

            return res;
        }
    }
}
