using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Longest_Consecutive_Sequence
    {
        /*
         
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            Sort(nums);
            int[] dp = new int[nums.Length];
            dp[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                switch (nums[i] - nums[i - 1])
                {
                    case 0:
                        dp[i] = dp[i - 1];
                        break;
                    case 1:
                        dp[i] = dp[i - 1] + 1;
                        break;
                    default:
                        dp[i] = 1;
                        break;
                }
            }
            return dp.Max();
        }
             */

        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;
            HashSet<int> num = new HashSet<int>(nums);
            int max = 1;
            while(num.Count!=0)
            {
                int cur = num.First();
                int curlength = 1;
                num.Remove(cur);
                int up = cur, down = cur;
                while(true)
                {
                    up++;
                    if (num.Contains(up))
                    {
                        curlength++;
                        num.Remove(up);
                    }
                    else break;
                }
                while(true)
                {
                    down--;

                    if (num.Contains(down))
                    {
                        curlength++;
                        num.Remove(down);
                    }
                    else break;
                }
                if (curlength > max) max = curlength;
            }
            return max;

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
