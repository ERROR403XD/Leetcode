using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ThreeSumClass
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int left = i + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        int temp = nums[i] + nums[left] + nums[right];
                        if (temp == 0)
                        {
                            List<int> tempList = new List<int>();
                            tempList.Add(nums[i]);
                            tempList.Add(nums[left]);
                            tempList.Add(nums[right]);
                            res.Add(tempList as IList<int>);
                            while (left < right)
                            {
                                left++;
                                if (nums[left] != nums[left - 1])
                                {
                                    break;
                                }
                            }
                        }
                        else if (temp < 0)
                        {
                            while (left < right)
                            {
                                left++;
                                if (nums[left] != nums[left - 1])
                                {
                                    break;
                                }   
                            }

                        }
                        else if (temp > 0)
                        {
                            while (left < right)
                            {
                                right--;
                                if (nums[right] != nums[right + 1])
                                {
                                    break;
                                }  
                            }
                        }
                    }
                }
            }
            return res as IList<IList<int>>;
        }
        /*
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            Sort(nums);

            for(int i = 0;i<nums.Length-2;i++)
            {
                if(i==0 || nums[i]!=nums[i-1])
                {
                    List<int[]> temp = Sum2(nums, i + 1, -nums[i]);
                    foreach (int[] tempPair in temp)
                    {
                        List<int> resTemp = new List<int>();
                        resTemp.Add(nums[i]);
                        resTemp.Add(tempPair[0]);
                        resTemp.Add(tempPair[1]);
                        res.Add(resTemp as IList<int>);
                    }
                }

            }     

            return res as IList<IList<int>>;  
        }   */
        private List<int[]> Sum2(int[]nums,int start,int target)
        {
            List<int> restore = new List<int>();
            List<int> already = new List<int>();
            List<int[]> res = new List<int[]>();

            for(int i = start;i<nums.Length;i++)
            {
                if(restore.Contains(nums[i]))
                {   
                    if(!already.Contains(nums[i]))
                    {
                        res.Add(new int[2] { target - nums[i], nums[i] });
                        already.Add(nums[i]);
                    }   
                }
                else
                { 
                    if(!restore.Contains(target-nums[i]))
                    {
                        restore.Add(target - nums[i]);
                    }    
                }
            }

            return res;
        }
        private void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }
        private void Sort(int[] nums,int start,int end)
        {
            if (end - start < 1) return;

            int compare = nums[start];
            int comparePos = start;
                                 
            for(int flag = start+1;flag<=end;flag++)
            {
                if(nums[flag]<=compare)
                {
                    Turn(ref nums[comparePos + 1], ref nums[flag]);
                    comparePos++;  
                }    
            }
            Turn(ref nums[start], ref nums[comparePos]);
            Sort(nums, start, comparePos - 1);
            Sort(nums, comparePos + 1, end);
        }
        private void Turn(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public int ThreeSumClosest(int[] nums, int target)
        {
            int res = nums[0] + nums[1] + nums[2];

            Sort(nums);

            for(int i = 0;i<nums.Length-2;i++)
            {    
                if(i==0 || nums[i]!=nums[i-1])
                {
                    int left = i + 1;
                    int right = nums.Length - 1;

                    while(left<right)
                    {
                        int temp = nums[i] + nums[left] + nums[right];

                        if(temp == target)
                        {
                            return target;
                        }
                        else
                        {
                            if(Math.Abs(target-temp)<Math.Abs(target-res))
                            {
                                res = temp;
                            }
                            if (temp < target)
                            {
                                while(left<right)
                                {
                                    left++;
                                    if (nums[left] != nums[left - 1]) break; 
                                }   
                            }
                            else
                            {
                                while (left < right)
                                {
                                    right--;
                                    if (nums[right] != nums[right + 1]) break;
                                }  
                            }
                        }  
                    }
                }     
            }

            return res;
        }
    }
}
