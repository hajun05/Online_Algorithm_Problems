using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] ingredient) 
    {
        List<int> totalIngredient = new List<int>();
        int answer = 0;
        
        foreach (int i in ingredient)
        {
            totalIngredient.Add(i);
            int count = totalIngredient.Count;
            if (count >= 4 &&
                totalIngredient[count - 4] == 1 &&
                totalIngredient[count - 3] == 2 &&
                totalIngredient[count - 2] == 3 &&
                totalIngredient[count - 1] == 1)
            {
                totalIngredient.RemoveRange(count - 4, 4);
                answer++;
            }
        }
        
        return answer;
    }
}