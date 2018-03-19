using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            int length = 1;
            for(int i = 1;i<nums.Length;i++)
            {
                if(nums[i]!=nums[length-1])
                {
                    nums[length] = nums[i];
                    length++;
                }
            }
            return length;
        }
        public int RemoveDuplicatesII(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            int res = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(int i in nums)
            {
                if (!dic.ContainsKey(i)) dic.Add(i, 1);
                else if (dic[i] < 2) dic[i]++;
            }
            int count = 0;
            foreach(int i in dic.Keys)
            {
                res += dic[i];
                for(int j = 0;j<dic[i];j++)
                {
                    nums[count] = i;
                    count++;
                }
            }
            return res;

        }
    }
}
