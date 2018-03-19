using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Add_Binary
    {
        public string AddBinary(string a, string b)
        {
            if (a == null || a.Length == 0) return b;
            if (b == null || b.Length == 0) return a;
            char one = '1';

            string res = "";

            string l = (a.Length > b.Length) ? a : b;
            string s = (a.Length > b.Length) ? b : a;
            bool plus = false;
            for(int i = 1;i<=l.Length;i++)
            {
                int dl = 0;
                int ds = 0;
                if (l[l.Length - i] == one) dl = 1;
                if (i <= s.Length && s[s.Length - i]==one) ds = 1; 

                int k = dl + ds + ((plus) ? 1 : 0);
                switch(k)
                {
                    case 0:
                        res = "0" + res;
                        plus = false;
                        break;
                    case 1:
                        res = "1" + res;
                        plus = false;
                        break;
                    case 2:
                        res = "0" + res;
                        plus = true;
                        break;
                    case 3:
                        res = "1" + res;
                        plus = true;
                        break;
                    default:
                        break;
                }
            }
            if (plus) res = "1" + res;
            return res;
        }
        
    }
}
