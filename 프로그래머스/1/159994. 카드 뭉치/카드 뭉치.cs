using System;

public class Solution 
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        int i1 = 0;
        int i2 = 0;
        
        foreach (string word in goal) 
        {
            if (i1 < cards1.Length && word == cards1[i1]) 
            {
                i1++;
            } 
            else if (i2 < cards2.Length && word == cards2[i2]) 
            {
                i2++;
            } 
            else 
            {
                return "No";
            }
        }
        
        return "Yes";
    }
}