using System;

public class Solution 
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        int[] answer = new int[2];
        int numerator = numer1 * denom2 + denom1 * numer2;
        int denominator = denom1 * denom2;
        
        if (numerator % denominator == 0)
        {
            answer[0] = numerator / denominator;
            answer[1] = 1;
        }
        else
        {
            for (int i = denominator / 2; i > 1; i--)
            {
                if (denominator % i == 0 && numerator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    
                    if (i > 2)
                        i = denominator / 2 + 1;
                }
            }
        
            answer[0] = numerator;
            answer[1] = denominator;
        }
        
        return answer;
    }
}