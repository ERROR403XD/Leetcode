using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Unique_Paths
    {
        public int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m, n];
            for(int i = 0;i < m;i++)
            {
                dp[i, 0] = 1;
            }
            for(int i = 0;i < n;i++)
            {
                dp[0, i] = 1;
            }

            for(int i = 1;i<m;i++)
            {
                for(int j = 1;j<n;j++)
                {
                    dp[i, j] = dp[i - 1,j] + dp[i, j - 1];
                }
            }
            return dp[m - 1, n - 1];
        }
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int m = obstacleGrid.GetLength(0);
            int n = obstacleGrid.GetLength(1);
            if (obstacleGrid[0, 0] == 1) return 0;
            else obstacleGrid[0, 0] = -1;
            for(int i = 1;i<m;i++)
            {
                if(obstacleGrid[i,0]!=1)obstacleGrid[i, 0] = obstacleGrid[i-1,0];
            }
            for(int i = 1;i<n;i++)
            {
                if (obstacleGrid[0, i] != 1) obstacleGrid[0, i] = obstacleGrid[0,i-1];
            }
            for(int i = 1;i<m;i++)
            {
                for(int j = 1;j<n;j++)
                {
                    if (obstacleGrid[i, j] == 1) continue;
                    if (obstacleGrid[i - 1, j] != 1) obstacleGrid[i, j] += obstacleGrid[i - 1, j];
                    if (obstacleGrid[i, j - 1] != 1) obstacleGrid[i, j] += obstacleGrid[i, j - 1];
                }
            }
            if (obstacleGrid[m - 1, n - 1] == 1) return 0;
            else return -obstacleGrid[m - 1, n - 1];
        }
    }
}
