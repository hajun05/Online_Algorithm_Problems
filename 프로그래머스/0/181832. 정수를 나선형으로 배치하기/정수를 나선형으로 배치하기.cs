using System;

public class Solution 
{
    // 달팽이 배열 알고리즘 문제
    public int[,] solution(int n) 
    {
        // 닶을 저장할 2차원 배열
        int[,] answer = new int[n,n];
        // 배열에 저장할 값
        int num = 1;
        
        // 좌표 설정
        int row = 0;
        int col = 0;
        
        // 시작점 설정
        answer[row, col] = num++;
        
        // 달팽이 배열 순회
        // 배열을 순회할때 배열 범위를 넘어서지 않도록 주의
        while(num <= n * n)
        {
            while (col + 1 < n && answer[row, col + 1] == 0)
            {
                answer[row, ++col] = num++;
            }
            while (row + 1 < n && answer[row + 1, col] == 0)
            {
                answer[++row, col] = num++;
            }
            while (col - 1 >= 0 && answer[row, col - 1] == 0)
            {
                answer[row, --col] = num++;
            }
            while (row - 1 >= 0 && answer[row - 1, col] == 0)
            {
                answer[--row, col] = num++;
            }
        }
        
        return answer;
    }
}