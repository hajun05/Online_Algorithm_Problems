using System;

public class Solution 
{
    public int[,] solution(int n) 
    {
        int[,] answer = new int[n, n];
        int num = 1;
        
        // 경계값 설정
        int startRow = 0, endRow = n - 1;
        int startCol = 0, endCol = n - 1;
        
        while (num <= n * n)
        {
            // 1. 오른쪽으로 이동 (상단 행)
            for (int col = startCol; col <= endCol; col++)
                answer[startRow, col] = num++;
            startRow++;
            
            // 2. 아래로 이동 (우측 열)
            for (int row = startRow; row <= endRow; row++)
                answer[row, endCol] = num++;
            endCol--;
            
            // 3. 왼쪽으로 이동 (하단 행)
            for (int col = endCol; col >= startCol; col--)
                answer[endRow, col] = num++;
            endRow--;
            
            // 4. 위로 이동 (좌측 열)
            for (int row = endRow; row >= startRow; row--)
                answer[row, startCol] = num++;
            startCol++;
        }
        
        return answer;
    }
}
