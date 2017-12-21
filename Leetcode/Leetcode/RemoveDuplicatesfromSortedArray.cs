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
    }
}
