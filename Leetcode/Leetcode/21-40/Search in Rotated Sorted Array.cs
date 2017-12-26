using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Search_in_Rotated_Sorted_Array
    {
        /*
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            if (nums.Length == 1)
            {
                if (nums[0] == target) return 0;
                else return -1;
            }
            int rotatedNum = FindRotatedNum(nums, 0, nums.Length - 1);
            if (target >= nums[0])
                return SearchInRange(nums, target, 0, nums.Length - rotatedNum - 1);
            else
                return SearchInRange(nums, target, nums.Length - rotatedNum , nums.Length-1);

        }
        private int FindRotatedNum(int[] nums,int start,int end)
        {
            if (nums[end] > nums[start]) return 0;
            int flag = (start + end) / 2;

            if(nums[flag]>nums[flag+1])
            {
                return end - flag;
            }
            if(nums[flag]<nums[start])
            {
                return FindRotatedNum(nums, start, flag - 1) + end - flag+1;
            }
            else
            {
                return FindRotatedNum(nums, flag + 1, end);
            }


        }
        private int SearchInRange(int[] nums,int target,int start,int end)
        {
            if (start > end) return -1;
            int flag = (start + end) / 2;
            
            if (nums[flag] == target) return flag;
            if (nums[flag] < target) return SearchInRange(nums, target, flag + 1, end);
            else return SearchInRange(nums, target, start, flag - 1);

        }
        */
        public int Search(int[] nums, int target)
        {
            if(nums==null||nums.Length==0)
            {
                return -1;
            }
            return BinarySearch(nums, target, 0, nums.Length - 1);
        }
        private int BinarySearch(int[] nums,int target,int start,int end)
        {
            if (start > end) return -1;
            int mid = (start + end) / 2;

            if (nums[mid] == target) return mid;

            if(nums[mid]<nums[start])
            {
                if(target>nums[mid]&&target<nums[start])
                {
                    return BinarySearch(nums, target, mid + 1, end);
                }
                else
                {
                    return BinarySearch(nums, target, start, mid - 1);
                }
            }
            else
            {
                if(target>nums[mid]||target<nums[start])
                {
                    return BinarySearch(nums, target, mid + 1, end);
                }
                else
                {
                    return BinarySearch(nums, target, start, mid - 1);
                }
            }

        }
    }
}
