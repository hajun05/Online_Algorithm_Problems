using System;

public class Solution 
{
    public int[] solution(int num, int total) 
    {
        int[] answer = new int[num];
        
        int quotient = total / num;
        int remainder = total % num;
        
        if (remainder > 0)
        {
            for (int i = 0; i < num; i++)
            {
                answer[i] = quotient - ((num / 2) - i) + 1;
            }
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                answer[i] = quotient - ((num / 2) - i);
            }
        }
        
        return answer;
    }
}