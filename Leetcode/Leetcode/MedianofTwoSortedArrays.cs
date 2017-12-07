using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class MedianofTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double target = 0;

            int[] arrayM = (nums1.Length > nums2.Length) ? nums1 : nums2;
            int[] arrayN = (nums1.Length > nums2.Length) ? nums2 : nums1;
            int m = arrayM.Length;
            int n = arrayN.Length;

            if(n == 0)
            {
                return (m % 2 == 1) ? (double)arrayM[m / 2] : ((double)arrayM[m/2-1]+(double)arrayM[m/2]) / 2;
            }

            bool isOdd = ((m + n) % 2 == 1) ? true : false;
            if(!isOdd)
            {
                if(arrayM.Last()>=arrayN.Last())
                {
                    m--;
                }
                else
                {
                    n--;
                }
            }
            if (arrayM[0] >= arrayN.Last())
            {
                if(isOdd)
                {
                    return (double)arrayM[(m + 2) / 2 - n];
                }
                else
                {
                    if(arrayM.Length == arrayN.Length)
                    {
                        return ((double)arrayN.Last() + (double)arrayM[0]) / 2;
                    }
                    else
                    {
                        return ((double)arrayM[(arrayM.Length+arrayN.Length)/2-1-arrayN.Length] + (double)arrayM[(arrayM.Length + arrayN.Length) / 2 - arrayN.Length]) / 2;
                    }
                }
            }
            if (arrayN[0] >= arrayM.Last())
            {
                if (isOdd)
                {
                    return (double)arrayN[(n + 2) / 2 - m];
                }
                else
                {
                    if (arrayN.Length == arrayM.Length)
                    {
                        return ((double)arrayM.Last() + (double)arrayN[0]) / 2;
                    }
                    else
                    {
                        return ((double)arrayN[(arrayN.Length + arrayM.Length) / 2 - 1 - arrayM.Length] + (double)arrayM[(arrayM.Length + arrayN.Length) / 2 - arrayM.Length]) / 2;
                    }
                }
            }
            int mleft = m / 2;
            int mright = m - 1 - mleft;
            int mcurrent = m / 2;

            int nleft = FindKth(arrayN, arrayM[mcurrent],0,n-1);
            int nright = n - nleft;

            int tleft = mleft + nleft;
            int tright = mright + nright;
            int ncurrent = nleft-1;
            int temp = 0;

            while (true)
            {      
                if (tleft == tright)
                {
                    if (isOdd)
                    {
                        target = (double)arrayM[mcurrent];
                    }
                    else
                    {
                        if(mcurrent == m-1)
                        {
                            target = ((double)arrayM[mcurrent] + (double)arrayN[ncurrent + 1]) / 2;
                            break;
                        }
                        target = ((double)arrayM[mcurrent] + (double)((arrayM[mcurrent + 1]< arrayN[ncurrent + 1]) ?arrayM[mcurrent+1] :arrayN[ncurrent+1] )) / 2;
                    }
                    break;
                }
                temp = (tright - tleft) / 2;
                ncurrent = (temp > 0) ? ncurrent + temp : ncurrent + temp + 1;
                nleft = ncurrent;
                nright = n - nleft - 1;

                mleft = FindKth(arrayM, arrayN[ncurrent], 0, m - 1);
                mright = m - mleft;
                mcurrent = mleft - 1;

                tleft = mleft + nleft;
                tright = mright + nright;

                if (tleft == tright)
                {
                    if (isOdd)
                    {
                        target = (double)arrayN[ncurrent];
                    }
                    else
                    {
                        if (ncurrent == n - 1)
                        {
                            target = ((double)arrayN[ncurrent] + (double)arrayM[mcurrent + 1]) / 2;
                            break;
                        }
                        target = ((double)arrayN[ncurrent] + (double)((arrayN[ncurrent + 1] < arrayM[mcurrent + 1]) ? arrayN[ncurrent + 1] : arrayM[mcurrent + 1])) / 2;
                    }
                    break;    
                }
                temp = (tright - tleft) / 2;
                mcurrent = (temp > 0) ? mcurrent + temp : mcurrent + temp + 1;
                mleft = mcurrent;
                mright = m - mleft - 1;

                nleft = FindKth(arrayN, arrayM[mcurrent], 0, n - 1);
                nright = n - nleft;
                ncurrent = nleft - 1;
                tleft = mleft + nleft;
                tright = mright + nright;
            }

            return target;
        }
        public int FindKth(int[] source, int target, int start, int end)
        {
            if(end<start)
            {
                return 0;
            }
            int length = end - start + 1;
            
            if(start == end)
            {
                if(source[start]>target)
                {
                    return 0;
                }
                else
                {
                    return start + 1;
                }
            }
            if (target >= source[start + length / 2])
            {
                return FindKth(source, target, start + length / 2, end);
            }
            else
            {
                return FindKth(source, target, start, start + length / 2 - 1);
            }
        }
        
    }
}
