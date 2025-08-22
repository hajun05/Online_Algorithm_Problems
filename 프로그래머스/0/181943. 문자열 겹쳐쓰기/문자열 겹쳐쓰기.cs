using System;

public class Solution 
{
    public string solution(string my_string, string overwrite_string, int s) 
    {
        int overwirteLength = overwrite_string.Length;
        string answer = my_string.Remove(s, overwirteLength).Insert(s, overwrite_string);
        
        return answer;
    }
}