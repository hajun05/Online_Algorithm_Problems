using System;
using System.Collections.Generic;

public class Solution 
{
    public bool solution(string s) 
    {
        Stack<int> scope = new Stack<int>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                scope.Push(1);
            }
            else if (s[i] == ')')
            {
                if (scope.Count == 0)
                {
                    return false;
                }
                scope.Pop();
            }
        }
        
        return scope.Count == 0;
    }
}