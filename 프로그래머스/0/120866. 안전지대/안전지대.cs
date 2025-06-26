using System;

public class Solution 
{
    public int solution(int[,] board) 
    {
        int boardSize = board.Length;
        int answer = boardSize;
        
        // 지뢰 기준 주변 8방향
        int[,] directions = new int[8,2] 
        {
            {-1, 0},
            {-1, -1},
            {-1, 1},
            {0, -1},
            {0, 1},
            {1, 0},
            {1, -1},
            {1, 1},
        };
        
        int n = board.GetLength(0);
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i,j] == 1)
                {
                    answer--;
                    // 지뢰 기준 방향을 배열로 저장, 반복문을 통해 코드 절약
                    for (int k = 0; k < 8; k++)
                    {
                        int y = i + directions[k,0];
                        int x = j + directions[k,1];
                        if (y >= 0 && x >= 0 && y < n && x < n)
                        {
                            if (board[y, x] == 0)
                            {
                                board[y, x] = -1;
                                answer--;
                            }
                        }
                    }
                }
            }
        }
        
        return answer;
    }
}