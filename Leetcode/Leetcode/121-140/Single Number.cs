using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Single_Number
    {
        public int SingleNumber(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++) res ^= nums[i];
            return res;

        }
        public int SingleNumberII(int[] nums)
        {
            char[] dig = new char[32];
            for(int i = 0;i<nums.Length;i++)
            {
                string s = Convert.ToString(nums[i], 2);
                for(int j = 0;j<s.Length;j++)
                {
                    if (s[s.Length - 1 - j] == '1') dig[dig.Length - 1 - j] = (char)((dig[dig.Length - 1 - j]+1) % 3);
                }
            }
            for(int i = 0;i<dig.Length;i++)
            {
                dig[i] += '0';
            }
            return Convert.ToInt32(new string(dig),2);
        }
    }
}
