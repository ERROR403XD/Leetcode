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
    }
}
