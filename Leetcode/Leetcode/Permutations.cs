using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new List<IList<int>>();
            }
            return Permute(nums, nums.Length - 1);
        }
        public IList<IList<int>> Permute(int[] nums,int end)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (end == 0)
            {
                res.Add(new int[1] { nums[0] });
                return res;  
            }

            IList<IList<int>> last = Permute(nums, end - 1);
            foreach(IList<int> current in last)
            {
                for(int i = 0;i<=current.Count;i++)
                {
                    List<int> temp = new List<int>(current);
                    temp.Insert(i, nums[end]);
                    res.Add(temp);
                }
            }
            return res;   
        }
        /*
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new List<IList<int>>();
            }
            return PermuteUnique(nums, nums.Length - 1);

        }
        public IList<IList<int>> PermuteUnique(int[] nums,int end)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (end == 0)
            {
                res.Add(new int[1] { nums[0] });
                return res;
            }

            IList<IList<int>> last = PermuteUnique(nums, end - 1);
            foreach (IList<int> current in last)
            {
                for (int i = 0; i <= current.Count; i++)
                {
                    List<int> temp = new List<int>(current);

                    temp.Insert(i, nums[end]);
                    bool judge = true;
                    foreach(IList<int> s in res)
                    {
                        if (Equal(s, temp))
                        {
                            judge = false;
                            break;
                        }
                    }
                    if(judge)res.Add(temp);
                     
                }
            }
            return res; 
        }                        
        private bool Equal(IList<int> a,IList<int> b)
        {
            if (a.Count != b.Count) return false;
            for(int i = 0;i<a.Count;i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true; 
        }         
             
             */
        
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new List<IList<int>>();
            }
            return PermuteUnique(nums, nums.Length - 1);

        }
        public IList<IList<int>> PermuteUnique(int[] nums,int end)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (end == 0)
            {
                res.Add(new int[1] { nums[0] });
                return res;
            }

            IList<IList<int>> last = PermuteUnique(nums, end - 1);
            foreach (IList<int> current in last)
            {
                for (int i = current.Count; i >=0; i--)
                {
                    List<int> temp = new List<int>(current);
                    if (i == current.Count || temp[i] != nums[end])
                    {
                        temp.Insert(i, nums[end]);
                        res.Add(temp);
                    }
                    else break;
                          
                }
            }
            return res; 
        }
    }
}
