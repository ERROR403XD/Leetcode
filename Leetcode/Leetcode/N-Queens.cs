using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class N_Queens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> res = new List<IList<string>>();
            if (n <= 0) return res;
            int[] pos = new int[n];
            BackTrack(res, pos, 0, n);
            return res;
        }
        private void BackTrack(List<IList<string>> res, int[] pos, int row, int n)
        {
            if (row == n)
            {
                res.Add(Convert(pos));  
            }
            else
            {
                for (int col = 0; col < n; col++)
                {
                    pos[row] = col;
                    if (IsVaild(pos, row))
                    {
                        BackTrack(res, pos, row + 1, n);
                    } 
                }     
            }


        }
        private bool IsVaild(int[] pos, int row)
        {
            for (int i = 0; i < row; i++)
            {
                if (pos[i] == pos[row] || Math.Abs(pos[row] - pos[i]) == Math.Abs(row - i)) return false;
            }
            return true;
        }

        private List<string> Convert(int[] pos)
        {
            List<string> res = new List<string>();
            int n = pos.Length;
            for(int i = 0;i<n;i++)
            {
                string s = "";
                for(int j = 0;j<pos[i];j++)
                {
                    s += ".";
                }
                s += "Q";
                for(int j = pos[i]+1;j<n;j++)
                {
                    s += ".";
                }
                res.Add(s);
            }
            return res;
        }
    }

}
