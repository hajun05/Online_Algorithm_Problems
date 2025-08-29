using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] prices) 
    {
        int[] answer = new int[prices.Length];
        Stack<int> periods = new Stack<int>();
        
        for (int i = 0; i < prices.Length; i++) 
        {
            while (periods.Count > 0 && prices[periods.Peek()] > prices[i]) 
            {
                int index = periods.Pop();
                answer[index] = i - index;
            }

            periods.Push(i);
        }

        while (periods.Count > 0) 
        {
            int index = periods.Pop();
            answer[index] = prices.Length - index - 1;
        }

        return answer;
    }
}