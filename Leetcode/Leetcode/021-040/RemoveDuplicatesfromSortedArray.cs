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
            int res = 1;
            int count = 1;
            for(int i = 1;i<nums.Length;i++)
            {
                if(nums[i]==nums[i-1])
                {
                    if (count == 2) continue;        
                    else
                    {
                        count++;
                        nums[res] = nums[i];
                        res++;
                    }
                }   
                else
                {
                    count = 1;
                    nums[res] = nums[i];
                    res++;
                }
            }
            return res;

        }
    }
}
