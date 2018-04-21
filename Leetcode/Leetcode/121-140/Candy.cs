using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Candy
    {
        public int GetCandy(int[] ratings)
        {
            if (ratings.Length <= 1) return ratings.Length;
            int[] candy = new int[ratings.Length];
            candy[0] = 1; 
            for(int i = 1;i<ratings.Length;i++)
            {
                if (ratings[i] > ratings[i - 1]) candy[i] = candy[i - 1] + 1;
                else candy[i] = 1;
            }
            for(int i = ratings.Length-2;i>=0;i--)
            {
                if (ratings[i] > ratings[i + 1]) candy[i] = Math.Max(candy[i], candy[i + 1] + 1);
            }
            return candy.Sum();
        }
        public int GetCandyII(int[] ratings)//not work
        {
            if (ratings.Length <= 1) return ratings.Length;
            int rise = 1;
            int fall = 1;
            int candy = 1;
            int lastcandy = 1;
            for(int i = 1;i<ratings.Length;i++)
            {
                if(ratings[i]>ratings[i-1])
                {
                    lastcandy++;
                    candy += lastcandy;
                    fall = 1;
                }
                else if(ratings[i]<ratings[i-1])
                {
                    fall++;
                    lastcandy--;
                    if (lastcandy == 0)
                    {
                        candy += fall;
                        lastcandy = 1;
                    }
                    else candy += lastcandy;
                }
                else
                {
                    candy += 1;
                    lastcandy = 1;
                    fall = 1;
                }
            }
            return candy;
        }
    }
}
