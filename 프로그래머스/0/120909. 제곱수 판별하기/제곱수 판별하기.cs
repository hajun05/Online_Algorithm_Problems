using System;

public class Solution 
{
    public int solution(int n) 
    {
        for (int i = 1; i * i <= n; i++)
        {
            if (n % i != 0)
                continue;
            if (n / i == i)
                return 1;
        }
        return 2;
    }
}