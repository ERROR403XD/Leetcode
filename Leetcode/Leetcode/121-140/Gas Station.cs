using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Gas_Station
    {
        private int turn(int length,int target)
        {
            if (target >= 0) return target%length;
            else return turn(length, target + length);
        }
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Length == 0) return -1;
            if(gas.Length==1)
            {
                if (cost[0] >= gas[0]) return 0;
                else return -1;
            }
            int[] income = new int[gas.Length];
            for(int i = 0;i<gas.Length;i++)
            {
                income[i] = gas[i] - cost[i];
            }
            int start = 0,end=1,save=income[0];
            while(start!=end)
            {
                if(save>=0)
                {
                    save += income[end];
                    end = turn(gas.Length, end + 1);
                }
                else
                {
                    start = turn(gas.Length, start - 1);
                    save += income[start];
                }
            }
            if (save < 0) return -1;
            else return start;
        }
    }
}
