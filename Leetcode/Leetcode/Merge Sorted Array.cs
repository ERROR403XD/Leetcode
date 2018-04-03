using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] merge = new int[m + n];
            for(int M=0,N=0;M<m||N<n;)
            {
                if(M==m)
                {
                    merge[M + N] = nums2[N];
                    N++;
                    continue;
                }
                if(N==n)
                {
                    merge[M + N] = nums1[M];
                    M++;
                    continue;
                }
                if(nums1[M]<nums2[N])
                {
                    merge[M + N] = nums1[M];
                    M++;
                }
                else
                {
                    merge[M + N] = nums2[N];
                    N++;
                }
            }
            for(int i =0;i<m+n;i++)
            {
                nums1[i] = merge[i];
            }
        }
    }
}
