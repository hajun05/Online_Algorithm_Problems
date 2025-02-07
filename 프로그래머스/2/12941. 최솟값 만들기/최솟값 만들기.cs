using System;

public class Solution 
{
    public int solution(int[] A, int[] B) 
    {
        int answer = 0;
        
        // 한 배열에서 작은 순, 다른 배열에서 큰 순으로 곱하기
        Array.Sort(A);
        Array.Sort(B);
        int n = A.Length;
        
        for (int i = 0; i < n; i++)
        {
            answer += A[i] * B[n - 1 - i];
        }
        
        return answer;
    }
}