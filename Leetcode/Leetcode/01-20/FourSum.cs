using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class FourSumClass
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> res = new List<IList<int>>();
            Sort(nums);

            for(int i = 0;i<nums.Length-3;i++)
            {
                if(i==0||nums[i]!=nums[i-1])
                {
                    for (int j = i + 1; j < nums.Length - 2; j++)
                    {
                        if(j==i+1||nums[j]!=nums[j-1])
                        {
                            //2sum
                            int left = j + 1;
                            int right = nums.Length - 1;
                            while(left<right)
                            {
                                int temp = nums[i] + nums[j] + nums[left] + nums[right];
                                if (temp == target)
                                {
                                    List<int> tempList = new List<int>();
                                    tempList.Add(nums[i]);
                                    tempList.Add(nums[j]);
                                    tempList.Add(nums[left]);
                                    tempList.Add(nums[right]);

                                    res.Add(tempList as IList<int>);

                                    while(left<right)
                                    {
                                        left++;
                                        if (nums[left] != nums[left - 1]) break;
                                    }
                                }
                                else if (temp<target)
                                {
                                    while (left < right)
                                    {
                                        left++;
                                        if (nums[left] != nums[left - 1]) break;
                                    }  
                                }
                                else
                                {
                                    while (left < right)
                                    {
                                        right-- ;
                                        if (nums[right] != nums[right + 1]) break;
                                    }   
                                }
                            }    
                        }
                    }
                }      
            }

            return res as IList<IList<int>>;
        }
        private void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }
        private void Sort(int[] nums, int start, int end)
        {
            if (end - start < 1) return;

            int compare = nums[start];
            int comparePos = start;

            for (int flag = start + 1; flag <= end; flag++)
            {
                if (nums[flag] <= compare)
                {
                    Turn(ref nums[comparePos + 1], ref nums[flag]);
                    comparePos++;
                }
            }
            Turn(ref nums[start], ref nums[comparePos]);
            Sort(nums, start, comparePos - 1);
            Sort(nums, comparePos + 1, end);
        }
        private void Turn(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
