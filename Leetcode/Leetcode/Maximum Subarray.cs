using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            int lastMin = 0;
            int maxSum = nums[0];
            if (maxSum < 0) lastMin = maxSum;
            for(int i = 1;i<nums.Length;i++)
            {
                nums[i] = nums[i - 1] + nums[i];
                if (nums[i] - lastMin > maxSum) maxSum = nums[i] - lastMin;
                if (nums[i] < lastMin) lastMin = nums[i];


            }
            return maxSum; 
        }
    }
}
