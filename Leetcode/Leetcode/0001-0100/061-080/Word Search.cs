using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Word_Search
    {
        public bool Exist(char[,] board, string word)
        {
            for(int i = 0;i<board.GetLength(0);i++)
            {
                for(int j = 0;j<board.GetLength(1);j++)
                {
                    if (Find(board, i, j, word)) return true; ;
                }
            }
            return false;
        }
        private bool Find(char[,] board,int i,int j,string word)
        {
            if(i<0||j<0||i>=board.GetLength(0)||j>=board.GetLength(1)||word[0]!=board[i,j])
            {
                return false;
            }
            else
            {
                if (word.Length == 1) return true;

                char store = board[i, j];
                board[i, j] = default(char);
                bool res = Find(board, i - 1, j, word.Substring(1)) || Find(board, i, j - 1, word.Substring(1)) || Find(board, i + 1, j, word.Substring(1)) || Find(board, i, j + 1, word.Substring(1));
                board[i, j] = store;
                return res;
            }
        }
    }
}
