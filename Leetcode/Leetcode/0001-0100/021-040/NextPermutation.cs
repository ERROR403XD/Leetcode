using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class NextPermutationClass
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length <= 1) return;
            for(int i = nums.Length-1;i>=1;i--)
            {
                if (nums[i - 1] < nums[i])
                {
                    for(int j = nums.Length-1;j>=i;j--)
                    {
                        if(nums[j]>nums[i-1])
                        {
                            Swap(ref nums[j], ref nums[i-1]);
                            Sort(nums, i, nums.Length - 1);
                            return;
                        }
                        
                    }
                }   
            }
            Sort(nums);   
        }
        private void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }
        private void Sort(int[] nums, int start, int end)
        {
            if (end - start < 1) return;

            int compare = nums[start];
            int comparePos = start;

            for (int flag = start + 1; flag <= end; flag++)
            {
                if (nums[flag] <= compare)
                {
                    Swap(ref nums[comparePos + 1], ref nums[flag]);
                    comparePos++;
                }
            }
            Swap(ref nums[start], ref nums[comparePos]);
            Sort(nums, start, comparePos - 1);
            Sort(nums, comparePos + 1, end);
        }
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
