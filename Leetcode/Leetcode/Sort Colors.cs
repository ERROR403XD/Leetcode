using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Sort_Colors
    {
        public void SortColors(int[] nums)
        {
            int r = 0, w = 0, b = 0;
            foreach(int i in nums)
            {
                switch(i)
                {
                    case 0:
                        r++;
                        break;
                    case 1:
                        w++;
                        break;
                    case 2:
                        b++;
                        break;
                    default:
                        break;
                }
            }
            for(int i = 0;i<r;i++)
            {
                nums[i] = 0;
            }
            for(int i = 0;i<w;i++)
            {
                nums[r + i] = 1;
            }
            for(int i = 0;i<b;i++)
            {
                nums[r + w + i] = 2;
            }
        }
        public void SortColorsConstSpace(int[] nums)
        {
            int r = -1, w = -1, b = -1;
            for(int i = 0;i<nums.Length;i++)
            {
                switch(nums[i])
                {
                    case 2:
                        b++;
                        break;
                    case 1:
                        Swap(ref nums[i], ref nums[w + 1]);
                        w++;
                        b++;
                        break;
                    case 0:
                        Swap(ref nums[i], ref nums[w + 1]);
                        b++;
                        Swap(ref nums[w + 1], ref nums[r + 1]);
                        w++;
                        r++;
                        break;
                    default:
                        break;
                }
            }
        }
        public void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
