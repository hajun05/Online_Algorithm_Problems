using System;

public class Solution 
{
    public int solution(int n, int w, int num) 
    {
        int answer = 0;
        
        while(num <= n)
        {
            if (num % w > 0)
                num += 2 * (w - (num % w)) + 1;
            else
                num++;
            answer++;
        }
        
        return answer;
    }
}