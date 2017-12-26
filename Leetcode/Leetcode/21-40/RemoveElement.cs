using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class RemoveElementClass
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int length = 0;
            for(int i = 0;i<nums.Length;i++)
            {
                if(nums[i]!=val)
                {
                    nums[length] = nums[i];
                    length++;
                }
            }
            return length;    
        }
    }
}
