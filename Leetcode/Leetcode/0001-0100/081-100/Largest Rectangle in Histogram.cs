using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Largest_Rectangle_in_Histogram
    {
        public int LargestRectangleArea(int[] heights)
        {
            if (heights.Length == 0) return 0;
            Stack<int> pos = new Stack<int>();
            pos.Push(0);
            int maxArea = heights[0];
            for(int i = 1;i<heights.Length;i++)
            {
                if(heights[i]>=heights[pos.Peek()])
                {
                    pos.Push(i);
                }
                else
                {
                    while(pos.Count!=0&&heights[pos.Peek()]>heights[i])
                    {
                        int current = pos.Pop();
                        int area;
                        if (pos.Count == 0) area = heights[current] * i;
                        else area = heights[current] * (i-pos.Peek()-1);
                        if (area > maxArea) maxArea = area;
                    }
                    pos.Push(i);
                }
            }
            while (pos.Count!=0)
            {
                int current = pos.Pop();
                //int area = heights[current] * (heights.Length - current);
                int area;
                if (pos.Count == 0) area = heights[current] * heights.Length;
                else area = heights[current] * (heights.Length - pos.Peek()-1);
                if (area > maxArea) maxArea = area;
            }
            return maxArea;

        }
    }
}
