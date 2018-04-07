using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Search_Insert_Position
    {
        public int SearchInsert(int[] nums, int target)
        {
            return SearchInsert(nums, target, 0, nums.Length - 1);   
        }
        private int SearchInsert(int[] nums,int target,int start,int end)
        {
            int mid = (start + end) / 2;
            if(nums[mid]<target)
            {
                if (mid == nums.Length - 1) return mid + 1;
                if (nums[mid + 1] > target) return mid + 1;
                return SearchInsert(nums, target, mid + 1, end); 
            }
            else if (nums[mid]>target)
            {
                if (mid == 0) return 0;
                if (nums[mid - 1] < target) return mid;
                return SearchInsert(nums, target, start, mid - 1);   
            }
            return mid;
        }
    }
}
