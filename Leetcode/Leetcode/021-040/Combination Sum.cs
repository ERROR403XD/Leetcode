using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Combination_Sum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            if (candidates.Length == 0) return null;
            List<IList<int>> res = new List<IList<int>>();
            Sort(candidates);

            ReveriseFrom(candidates, target, 0, res,new List<int>());
                

            return res;
        }
        private bool ReveriseFrom(int[] candidates,int target,int startIndex,List<IList<int>>res,List<int> tempList)
        {
            if (target < 0) return false;
            else if(target==0)
            {
                res.Add(new List<int>(tempList));
                return false;    
            }   
            else
            {
                for(int i = startIndex;i<candidates.Length;i++)
                {
                    tempList.Add(candidates[i]);
                    bool flag = ReveriseFrom(candidates, target - candidates[i], i, res, tempList);
                    tempList.RemoveAt(tempList.Count - 1);
                    if (!flag) break;
                }
                return true;
            }
             
        }
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            if (candidates.Length == 0) return null;
            List<IList<int>> res = new List<IList<int>>();
            Sort(candidates);

            ReveriseFrom2(candidates, target, 0, res, new List<int>());


            return res;
        }
        private bool ReveriseFrom2(int[] candidates, int target, int startIndex, List<IList<int>> res, List<int> tempList)
        {
            if (target < 0) return false;
            else if (target == 0)
            {
                res.Add(new List<int>(tempList));
                return false;
            }
            else
            {
                for (int i = startIndex; i < candidates.Length; i++)
                {
                    if (i > startIndex && candidates[i] == candidates[i - 1]) continue;
                    tempList.Add(candidates[i]);
                    bool flag = ReveriseFrom2(candidates, target - candidates[i], i+1, res, tempList);
                    tempList.RemoveAt(tempList.Count - 1);
                    if (!flag) break;
                }
                return true;
            }

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
                    Swap(ref nums[comparePos + 1], ref nums[flag]);
                    comparePos++;
                }
            }
            Swap(ref nums[start], ref nums[comparePos]);
            Sort(nums, start, comparePos - 1);
            Sort(nums, comparePos + 1, end);
        }
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
