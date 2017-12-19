using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ThreeSumClass
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> resList = new List<List<int>>();

            for(int i = 0; i < nums.Length-2; i++)
            {
                int res = nums[i];
                for(int j = i+1;j<nums.Length-1;j++)
                {
                    int res2 = res + nums[j];
                    for(int k = j+1;k<nums.Length;k++)
                    {
                        if(nums[k]==-res2)
                        {
                            List<int> tempres = new List<int>();
                            tempres.Add(nums[i]);
                            tempres.Add(nums[j]);
                            tempres.Add(nums[k]);

                            resList.Add(tempres);
                        }
                    }
                }
            }

            return resList;
        }                                                     
    }
}
