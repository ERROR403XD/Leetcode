using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Search_in_Rotated_Sorted_Array_II
    {
        public bool Search(int[] nums, int target)
        {
            return Search(nums, 0, nums.Length - 1, target);
        }
        private bool Search(int[] nums,int start,int end,int target)
        {
            if (start > end) return false;
            if(end-start<=5)
            {
                for(int i = start;i<=end;i++)
                {
                    if (nums[i] == target) return true; 
                }
                return false;
            }
            int mid = (start + end) / 2;
            if (target == nums[start] || target == nums[mid] || target == nums[end]) return true;

            if(mid<nums.Length-1&&nums[mid]>nums[mid+1])
            {
                if (target > nums[start]) return NormalSearch(nums, start, mid - 1, target);
                else return NormalSearch(nums, mid + 1, end, target);
            }

            if(nums[mid]>nums[start])
            {
                if (target < nums[mid]) return NormalSearch(nums, start, mid - 1, target);
                else return Search(nums, mid + 1, end, target);

            }
            else
            {
                return Search(nums, start + 1, end, target);
            }

        }
        private bool NormalSearch(int[] nums,int start,int end,int target)
        {
            if(start>end)
            {
                return false;
            }
            else if(start==end)
            {
                return nums[start] == target;
            }
            else
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target) return true;
                else if (nums[mid] > target) return NormalSearch(nums, start, mid - 1, target);
                else return NormalSearch(nums, mid + 1, end, target);
            }
        }
    }
}
