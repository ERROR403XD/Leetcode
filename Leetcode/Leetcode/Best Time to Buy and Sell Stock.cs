using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int min = prices[0];
            int maxdif = 0;
            for(int i = 1;i<prices.Length;i++)
            {
                if (prices[i] < min) min = prices[i];
                if (prices[i] - min > maxdif) maxdif = prices[i] - min;
            }
            return maxdif;

        }
        public int MaxProfitII(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int min = prices[0];
            int maxdif = 0;
            for(int i = 1;i<prices.Length;i++)
            {
                if (prices[i] < prices[i - 1])
                {
                    if (prices[i - 1] > min) maxdif += prices[i - 1] - min;
                    min = prices[i];
                }
                else if (i == prices.Length - 1 && prices[i] > min) maxdif += prices[i] - min;
            }
            return maxdif;
        }

        public int MaxProfitIII(int[]prices)
        {
            if (prices.Length <= 1) return 0;
            int[] local = new int[3];
            int[] global = new int[3];
            for(int i = 0;i<prices.Length-1;i++)
            {
                int dif = prices[i + 1] - prices[i];
                for(int j = 2;j>=1;j--)
                {
                    local[j] = Math.Max(global[j - 1] + (dif > 0 ? dif : 0), local[j] + dif);
                    global[j] = Math.Max(local[j], global[j]);
                }
            }
            return global[2];
        }
    }
}
