using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Gray_Code
    {
        public IList<int> GrayCode(int n)
        {
            if (n == 0) return new List<int>() { 0};
            if(n==1)return new List<int>() { 0,1};
            List<int> res = (List<int>)GrayCode(n - 1);
            int length = res.Count;
            int add = Pow(n - 1);
            for(int i = length-1;i>=0;i--)
            {
                res.Add(res[i] + add);
            }

            return res;
        }
        private int Pow(int x)
        {
            if (x == 0) return 1;
            if (x == 1) return 2;
            int temp = Pow(x / 2);
            if (x % 2 == 0) return temp * temp;
            else return temp * temp * 2;
        }

    }
}
