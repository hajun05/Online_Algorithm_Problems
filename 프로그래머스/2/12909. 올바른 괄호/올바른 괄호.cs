using System;
using System.Collections.Generic;

public class Solution 
{
    public bool solution(string s) 
    {
        bool answer = true;
        
        List<byte> scope = new List<byte>();
        int strN = s.Length;
        for (int i = 0; i < strN; i++)
        {
            if(s[i] == '(')
            {
                scope.Add(1);
            }
            else if(s[i] == ')')
            {
                if(scope.Count == 0)
                {
                    return false;
                }
                scope.RemoveAt(0);
            }
        }
        
        if(scope.Count > 0)
            answer = false;
        else
            answer = true;
        return answer;
    }
}