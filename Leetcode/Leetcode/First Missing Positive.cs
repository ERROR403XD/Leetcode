using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class First_Missing_Positive
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums==null||nums.Length == 0) return 1;  
            
            for(int i = 0;i<nums.Length;i++)
            {
                while(nums[i]>0&&nums[i]<=nums.Length &&nums[nums[i]-1]!=nums[i])
                {
                    Swap(ref nums[i], ref nums[nums[i] - 1]);
                }
            }

            for(int i = 0;i<nums.Length;i++)
            {
                if (nums[i] != i + 1) return i + 1;
            }
            return nums.Length+1;
        }
        private void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
