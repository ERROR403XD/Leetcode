using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Subsets
    {
        public IList<IList<int>> Subsets_(int[] nums)
        {
            return Subsets_(nums, nums.Length - 1);

        }
        public IList<IList<int>> Subsets_(int[] nums,int end)
        {
            IList<IList<int>> res;
            if(end==-1)
            {
                res = new List<IList<int>>();
                res.Add(new List<int>());
                return res;
            }
            else
            {
                res = Subsets_(nums, end - 1);
                int flag = res.Count;
                for(int i = 0;i<flag;i++)
                {
                    List<int> temp = new List<int>(res[i]);
                    temp.Add(nums[end]);
                    res.Add(temp);
                }
                return res;
            }
        }

        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>() { new List<int>()};
            if (nums.Length == 0) return res;
            Sort(nums);
            int num = nums[0];
            int count = 1;
            for(int i = 1;i<nums.Length+1;i++)
            {
                if(i==nums.Length||num!=nums[i])
                {
                    int curNum = res.Count;
                    for(int j = 1;j<=count;j++)
                    {
                        for(int k = 0;k<curNum;k++)
                        {
                            List<int> temp = new List<int>(res[k]);
                            for(int m = 1;m<=j;m++)
                            {
                                temp.Add(num);
                            }
                            res.Add(temp);
                        }
                    }
                    if(i!=nums.Length)
                    {
                        num = nums[i];
                        count = 1;
                    }
                }
                else
                {
                    count++;
                }

            }
            return res;
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
