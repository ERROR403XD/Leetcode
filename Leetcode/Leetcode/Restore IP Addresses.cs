using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Restore_IP_Addresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            List<string> res = new List<string>();
            if (s.Length < 4 || s.Length > 12) return res;
            
            for(int l1=1;l1<=3;l1++)
            {
                for(int l2=1;l2<=3;l2++)
                {
                    for(int l3=1;l3<=3;l3++)
                    {
                        if (l1+l2>=s.Length||l1 + l2 + l3 >=s.Length) break;
                        string s1 = s.Substring(0, l1);
                        string s2 = s.Substring(l1, l2);
                        string s3 = s.Substring(l1 + l2, l3);
                        string s4 = s.Substring(l1 + l2 + l3);
                        if (Avi(s1) && Avi(s2) && Avi(s3) && Avi(s4)) res.Add(s1 + "." + s2 + "." + s3 + "." + s4);
                    }
                }
            }
            return res;

        }
        private bool Avi(string s)
        {
            if ((s.Length > 1 && s[0] == '0')|| s.Length > 3) return false;
            if (s.Length == 3 && (s[0]>='3'||(s[0]=='2'&&(s[1]>'5'||(s[1]=='5'&&s[2]>'5'))))) return false;
            return true;
        }
    }
}
