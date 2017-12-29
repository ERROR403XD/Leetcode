using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Trapping_Rain_Water
    {
        /*
         public int Trap(int[] height)
        {
            if (height == null || height.Length <= 2) return 0;
            int maxIndex = 0;
            for(int i = 0;i<height.Length;i++)
            {
                if (height[i] > height[maxIndex]) maxIndex = i;
            }
            int water = 0;
            bool filling = false;
            int startIndex = 0;
            for(int i =0;i<=maxIndex;i++)
            {
                if (filling)
                {
                    if(height[i]<height[startIndex])//可以填水
                    {
                        water += (height[maxIndex] - height[i]);
                    }
                    else
                    {
                        filling = false;
                        water -= ((i - startIndex-1) * (height[maxIndex]-height[startIndex]));
                        if (i + 1 < maxIndex && height[i + 1] < height[i])
                        {
                            filling = true;
                            startIndex = i;
                        }
                    }   
                }
                else
                {
                    if (i + 1 < maxIndex&& height[i+1]<height[i])
                    {
                        filling = true;
                        startIndex = i;
                    }          
                }
            }
            startIndex = height.Length - 1;
            filling = false;
            for(int i = height.Length-1;i>=maxIndex;i--)
            {
                if(filling)
                {
                    if (height[i] < height[startIndex])//可以填水
                    {
                        water += (height[maxIndex] - height[i]);
                    }
                    else
                    {
                        filling = false;
                        water -= ((startIndex - i - 1) * (height[maxIndex] - height[startIndex]));
                        if (i-1>maxIndex && height[i - 1] < height[i])
                        {
                            filling = true;
                            startIndex = i;
                        }
                    }

                }
                else
                {
                    if (i - 1 > maxIndex && height[i - 1] < height[i])
                    {
                        filling = true;
                        startIndex = i;
                    }

                }

            }

            return water;

        }             */

        public int Trap(int[] height)
        {
            if (height == null || height.Length <= 2) return 0;
            int maxIndex = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > height[maxIndex]) maxIndex = i;
            }
            int water = 0;
            int last = height[0];
            for(int i = 0;i<maxIndex;i++)
            {
                if(height[i]<last)
                {
                    water += (last - height[i]);
                }
                else
                {
                    last = height[i];
                }
            }
            last = height[height.Length - 1];
            for (int i = height.Length-1; i >maxIndex; i--)
            {
                if (height[i] < last)
                {
                    water += (last - height[i]);
                }
                else
                {
                    last = height[i];
                }
            }
            return water;
        }
    }
}
