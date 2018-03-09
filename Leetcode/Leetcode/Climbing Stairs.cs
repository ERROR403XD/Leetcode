﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 0) return 1;
            if (n <= 3) return n;
            int[] dp = new int[n + 1];
            dp[0] = 1;dp[1] = 1;dp[2] = 2;
            for(int i = 3;i<=n;i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
