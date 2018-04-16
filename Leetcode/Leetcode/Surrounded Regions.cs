using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Surrounded_Regions
    {
        public void Solve(char[,] board)
        {
            int row = board.GetLength(0), col = board.GetLength(1);
            for(int i =0;i<row;i++)
            {
                for(int j = 0;j<col;j++)
                {
                    if((i==0||i==row-1||j==0||j==col-1)&&board[i,j]=='O')
                    {
                        Fill(board, i, j, row, col);
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i, j] == 'O') board[i, j] = 'X';
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i, j] == 'A') board[i, j] = 'O';
                }
            }
        }
        private bool JudgeIn(char[,]board,int row,int col,int i,int j)
        {
            if (!(i >= 0 && j >= 0 && i < row && j < col)) return false;
            if (board[i, j] != 'O') return false;
            return true;
        }
        private void Fill(char[,] board,int i,int j,int row,int col)
        {
            board[i, j] = 'A';
            if (JudgeIn(board, row, col, i - 1, j)) Fill(board, i - 1, j, row, col);
            if (JudgeIn(board, row, col, i + 1, j)) Fill(board, i + 1, j, row, col);
            if (JudgeIn(board, row, col, i, j - 1)) Fill(board, i, j - 1, row, col);
            if (JudgeIn(board, row, col, i, j + 1)) Fill(board, i, j + 1, row, col);
        }
    }
}
