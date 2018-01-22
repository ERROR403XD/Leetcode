using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Jump_Game_II
    {
        /*
        public int Jump(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return 0;
            int res = 1;
            int current = 0;
            int[] dp = new int[nums.Length];
            while(true)
            {
                int target = current + nums[current];
                if (target >= nums.Length - 1) return res;
                dp[current] = target;       
                int reach = current;   
                for (int i = current+1;i<=target;i++)
                {
                    if (dp[i] == 0) dp[i] = i + nums[i];
                    if (dp[i] > dp[reach]) reach = i;
                    if (reach >= nums.Length - 1) return res + 1; 
                }
                current = reach;
                res++;    
            }     
        } 
             */
        public int Jump(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return 0;
            int step = 0;
            int lastreach = 0;
            int reach = 0;
            for(int i = 0;i<nums.Length;i++)
            {
                if(i>lastreach)
                {
                    step++;
                    lastreach = reach;
                }
                reach = Math.Max(reach, i + nums[i]);
            }
            return step;

        }
        public bool CanJump(int[] nums)
        {
            bool res = false;    
            int reach = nums[0];
            for(int i = 0;i<nums.Length;i++)
            {
                nums[i] = i + nums[i];
            }
            int j = 0;
            while(j<reach)
            {
                if (j >= nums.Length) return true;
                int maxreach = nums[j];
                for(int k = j;k<=nums[j];k++)
                {
                    if (nums[k] > maxreach) maxreach = nums[k];
                }
                j = maxreach;

            }
            return res;
        }

    }
}
