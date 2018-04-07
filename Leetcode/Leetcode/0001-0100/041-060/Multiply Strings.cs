using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Multiply_Strings
    {
        /*
        public string Multiply(string num1, string num2)
        {
            string res = "";
            string longer = (num1.Length > num2.Length) ? num1 : num2;
            string another = (num1.Length > num2.Length) ? num2 : num1;

            for(int i = another.Length-1;i>=0;i--)
            {
                string temp = Multiply(longer, another[i]);
                for(int j = another.Length-1;j>i;j--)
                {
                    temp += "0";
                }
                res = Add(res, temp);
            }

            return res;

        }
        public string Multiply(string num1,char num2)
        {
            if (num2 == '0') return "0";
            if (num2 == '1') return num1;
            int times = (int)num2 - 48;
            string res = "";
            int digPlus = 0;
            for(int i = num1.Length-1;i>=0;i--)
            {
                int dig = ((int)num1[i] - 48) * times + digPlus;    
                res = ((char)(dig%10+48)).ToString() + res;
                digPlus = dig / 10;    
            }
            if(digPlus!=0)res = ((char)(digPlus % 10+48)).ToString() + res;
            return res;
        }
        public string Add(string num1,string num2)
        {
            string res = "";
            string longer = (num1.Length > num2.Length) ? num1 : num2;
            string another = (num1.Length > num2.Length) ? num2 : num1;
            int digPlus = 0;
            for(int i = longer.Length-1;i>=0;i--)
            {
                int j = another.Length - (longer.Length - i);
                int dig;
                if (j >= 0)
                {
                    dig = (int)(longer[i]) - 48 + (int)(another[j]) - 48 + digPlus;
  
                }
                else
                {
                    dig = (int)(longer[i]) - 48 + digPlus;
                }

                if (dig >= 10)
                {
                    digPlus = 1;
                    dig -= 10;
                }
                else
                {
                    digPlus = 0;
                }

                res = ((char)(dig + 48)).ToString() + res;  
            }
            if (digPlus == 1) res = "1" + res;
            return res;   
        }
        */
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";
            string res = "";
            int[] buffer = new int[num1.Length + num2.Length];
            int compare = num1.Length + num2.Length - 2;
            int carry = 0;
            for(int i = 0;i<num1.Length;i++)
            {
                for(int j = 0;j<num2.Length;j++)
                {
                    buffer[compare - i - j] += (num1[i] - '0') * (num2[j] - '0');
                }
            }
            for(int i = 0;i<buffer.Length;i++)
            {
                buffer[i] += carry;
                carry = buffer[i] / 10;
                buffer[i] %= 10;
            }
            int t = buffer.Length - 1;
            while (buffer[t] == 0) t--;
            if (t < 0) return "0";
            while(t>=0)
            {
                res += ((char)(buffer[t] + '0')).ToString();
                t--;
            }
            return res;   
        }
    }
}
