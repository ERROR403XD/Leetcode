using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Sudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            List<char> restoreHor = new List<char>();
            List<char> restoreVer = new List<char>();
            for(int i = 0;i<9;i++)
            {
                for(int j = 0;j<9;j++)
                {
                    if(board[i,j]!='.')
                    {
                        if(restoreHor.Contains(board[i,j]))
                        {
                            return false;
                        }
                        restoreHor.Add(board[i, j]);
                    }
                    if (board[j, i] != '.')
                    {
                        if (restoreVer.Contains(board[j, i]))
                        {
                            return false;
                        }
                        restoreVer.Add(board[j, i]);
                    }
                }
                restoreHor.Clear();
                restoreVer.Clear();
            }
            for(int i = 0;i<=6;i+=3)
            {
                for(int j = 0;j<=6;j+=3)
                {
                    for(int hor = i;hor<i+3;hor++)
                    {
                        for(int ver = j;ver<j+3;ver++)
                        {
                            if(board[hor,ver]!='.')
                            {
                                if (restoreHor.Contains(board[hor, ver])) return false;
                                restoreHor.Add(board[hor, ver]);
                            }
                            
                        }
                    }
                    restoreHor.Clear();
                }
            }

            return true;
        }
        public void SolveSudoku(char[,] board)
        {
            
            List<char> stanard = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<char>[,] res = new List<char>[9, 9];
            Print(board, res,0,0);
            for (int i = 0;i<9;i++)
            {
                for(int j = 0;j<9;j++)
                {
                    if (board[i, j] != '.') Modify(board, i, j, res, stanard);
                }
            } 
        }
        private void Modify(char[,] board,int i,int j,List<char>[,] res,List<char> stanard)
        {
            for(int hor = 0;hor<9;hor++)
            {
                if(hor!=i&&board[hor,j]=='.')
                {
                    if(res[hor,j]==null)
                    {
                        res[hor, j] = new List<char>(stanard);
                    }
                    res[hor, j].Remove(board[i, j]);
                    if(res[hor,j].Count==1)
                    {
                        board[hor, j] = res[hor, j][0];
                        Modify(board, hor, j, res, stanard);     
                    }
                }
                if (hor != j && board[i,hor] == '.')
                {
                    if (res[i, hor] == null)
                    {
                        res[i, hor] = new List<char>(stanard);
                    }
                    res[i, hor].Remove(board[i, j]);
                    if (res[i, hor].Count == 1)
                    {
                        board[i, hor] = res[i, hor][0];
                        Modify(board, i, hor, res, stanard); 
                    }
                }
            }

            int horStart = (i / 3) * 3;
            int verStart = (j / 3) * 3;
            for(int k = horStart; k< horStart + 3;k++)
            {
                for(int l = verStart; l< verStart + 3;l++)
                {
                    if(k!=i&&l!=j&&board[k,l]=='.')
                    {
                        if (res[k,l] == null)
                        {
                            res[k, l] = new List<char>(stanard);
                        }
                        res[k, l].Remove(board[i,j]);
                        if (res[k, l].Count == 1)
                        {
                            board[k, l] = res[k, l][0];
                            Modify(board, k, l, res, stanard);   
                        }

                    }
                }
            }
            Print(board, res,i,j);
        }

        private void Print(char[,]board,List<char>[,] res,int k,int l)
        {

            Console.WriteLine();
            Console.WriteLine((k+1).ToString() + "  " + (l+1).ToString());
            for (int i = 0;i<9;i++)
            {
                for(int j = 0;j<9;j++)
                {
                    Console.Write(board[i, j].ToString() + " ");
                }
                Console.Write("     ");
                for(int j = 0;j<9;j++)
                {
                    if(res[i,j]==null)
                    {
                        if(board[i,j]=='.')Console.Write(". ");
                        else Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(res[i,j].Count.ToString()+" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
