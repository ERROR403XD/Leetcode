using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (s == null) return "";
            if (s.Length <= 1) return s;
            char flag = default(char);
            string source = flag.ToString();
            for(int i = 0;i<s.Length;i++)
            {
                source += s[i]+ flag.ToString();
            }
            int[] digs = new int[source.Length];

            int currentMaxPos = 0;
            int currentMaxBoundary = 0;
            int currentMaxBoundary_ = 0;

            int maxPos = 0;
            int maxVal = 0;
            for(int i = 0;i<source.Length;i++)
            {
                int currentBoundary = 0;
                
                if(i<=currentMaxBoundary)
                {
                    int opposite = currentMaxPos - (i - currentMaxPos);
                    digs[i] = digs[opposite];
                    if (opposite - digs[opposite]> currentMaxBoundary_)
                    {
                        continue;
                    }
                }  

                while(true)
                {
                    if(i-currentBoundary-1<0||i+currentBoundary+1>=digs.Length)
                    {
                        break;
                    }
                    if(source[i+currentBoundary+1]==source[i-currentBoundary-1])
                    {
                        currentBoundary++;
                    }
                    else
                    {
                        break;
                    }
                    digs[i] = currentBoundary;

                    if(currentBoundary>maxVal)
                    {
                        maxPos = i;
                        maxVal = currentBoundary;
                    }

                    if(maxPos+maxVal>=source.Length)
                    {
                        break;
                    }
                    if(i+currentBoundary>currentMaxBoundary)
                    {
                        currentMaxPos = i;
                        currentMaxBoundary = i + currentBoundary;
                        currentMaxBoundary_ = i - currentBoundary;
                    }
                }
            }

            string res = s.Substring(maxPos/2-maxVal/2,maxVal);
            /*
            if(maxPos%2==0)
            {
                res = "";
            }
            else
            {
                res = source[maxPos].ToString();
            }
            for(int i =maxPos+1;i<=maxPos+maxVal;i++)
            {
                if(source[i] != default(char))
                {
                    res = source[i].ToString() + res + source[i].ToString();
                }
            }
             */
            for (int i = 0;i<digs.Length;i++)
            {
                Console.Write(digs[i].ToString() + " ");
            }   
            Console.WriteLine();
            Console.WriteLine(source);
            Console.WriteLine(res);
            return res;
        }
    }
}
