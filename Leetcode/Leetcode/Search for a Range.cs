using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Search_for_a_Range
    {
        /*
                public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return new int[2] { -1, -1 };
            return BinarySearch(nums, target, 0, nums.Length - 1);
        }
        private int[] BinarySearch(int[] nums,int target,int start,int end)
        {
            if (start > end) return new int[2] { -1, -1 };
            int mid = (start + end) / 2;
            if(nums[mid]>target)
            {
                return BinarySearch(nums, target, start, mid - 1);
            }
            else if (nums[mid]<target)
            {
                return BinarySearch(nums, target, mid + 1, end);
            }
            else
            {
                return new int[2] { BinarySearchFront(nums, target, start, mid), BinarySearchBehind(nums, target, mid, end) };
                
            }
        }
        private int BinarySearchFront(int[] nums,int target,int start,int end)
        {

            int mid = (start + end)/2;
            if(nums[mid]==target)
            {
                if (mid == end) return mid;
                else return BinarySearchFront(nums, target, start, mid);
            }
            else
            {
                return BinarySearchFront(nums, target, mid + 1, end);
            }

        }
        private int BinarySearchBehind(int[] nums, int target, int start, int end)
        {
            int mid = (start + end+1)/2;
            if (nums[mid] == target)
            {
                if (mid == start) return mid;
                else return BinarySearchBehind(nums, target, mid, end);
            }
            else
            {
                return BinarySearchBehind(nums, target, start, mid-1);
            }

        } 
             */
        public int[] SearchRange(int[] nums, int target)
        {
            return new int[2] {SearchFirst(nums,target,0,nums.Length-1),SearchLast(nums,target,0,nums.Length-1)};
        }
        private int SearchFirst(int[] nums,int target,int start,int end)
        {
            if (start > end) return -1;
            int mid = (start + end) / 2;
            if(nums[mid]>target)
            {
                return SearchFirst(nums, target, start, mid - 1);
            }
            else if(nums[mid]<target)
            {
                return SearchFirst(nums, target, mid + 1, end);
            }

            if(mid==0||nums[mid-1]<target)
            {
                return mid;
            }
            return SearchFirst(nums, target, start, mid - 1);    
        }
        private int SearchLast(int[] nums,int target,int start,int end)
        {
            if (start > end) return -1;
            int mid = (start + end) / 2;
            if (nums[mid] > target)
            {
                return SearchLast(nums, target, start, mid - 1);
            }
            else if (nums[mid] < target)
            {
                return SearchLast(nums, target, mid + 1, end);
            }

            if (mid == nums.Length-1 || nums[mid + 1] > target)
            {
                return mid;
            }
            return SearchLast(nums, target, mid+1,end); 
        }

    }
}
