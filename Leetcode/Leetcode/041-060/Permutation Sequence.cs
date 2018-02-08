using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Permutation_Sequence
    {
        public string GetPermutation(int n, int k)
        {
            char[] res = new char[n];
            List<char> chose = new List<char>();
            for(int i = 1;i<=n;i++)
            {
                chose.Add((char)(i + '0'));
            }
            GetNext(res, chose, 0, k);
            return new string(res);
        }
        private void GetNext(char[] res,List<char> chose,int dig,int k)
        {
            if (dig == res.Length) return;
            int num = chose.Count;
            int nextNum = Fact(num - 1);
            int current = (k-1) / nextNum;
            k = k -current*nextNum;
            res[dig] = chose[current];
            chose.RemoveAt(current);
            GetNext(res, chose, dig + 1, k);
        }
        private int Fact(int n)
        {
            if (n == -1) return -1;
            if (n == 0) return 1;
            return n * Fact(n - 1);
        }

    }
}
