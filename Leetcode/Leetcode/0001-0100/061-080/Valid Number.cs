using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Valid_Number
    {
        public bool IsNumber(string s)
        {
            int start = 0;
            while(s[start]==' ')
            {
                start++;
                if (start == s.Length) return false;
            }
            int end = s.Length - 1;
            while(s[end]==' ')
            {
                end--;
                if (end == -1) return false;
            }

            bool canUseComa = true;
            bool canUseE = true;
            bool isNumber = false;
            for(int i = start;i<=end;i++)
            {
                if(s[i]=='-'||s[i]=='+')
                {
                    if (i != start) return false;
                    else continue;
                }
                if(s[i]=='.'&&!(i==start&&i==end))
                {
                    if (canUseComa)
                    {
                        canUseComa = false;
                        continue;
                    }
                    else return false;
                }
                if(s[i]=='e')
                {
                    if (canUseE && i != end&& i != start&&isNumber)
                    {
                        canUseE = false;
                        canUseComa = false;
                        continue;
                    }
                    else return false;
                }
                if (s[i] < '0' || s[i] > '9') return false;
                isNumber = true;
            }

            return isNumber;

        }
    }
}
