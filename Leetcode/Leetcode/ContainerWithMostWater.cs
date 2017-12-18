using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            if(height == null)
            {
                return 0;
            }
            
            int start = 0;
            int end = height.Length - 1;

            int[] results = new int[height.Length];
            int resMark = 0;
            
            while(start!=end)
            {
                results[resMark] = (end - start) * Math.Min(height[start], height[end]);
                resMark++;
                if(height[end]>height[start])
                {
                    start++;
                }
                else
                {
                    end--;
                }

            }

            return results.Max();

        }
    }
}
