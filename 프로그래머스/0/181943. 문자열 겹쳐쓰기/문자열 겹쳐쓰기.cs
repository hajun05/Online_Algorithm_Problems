using System;
using System.Text;

public class Solution 
{
    public string solution(string my_string, string overwrite_string, int s) 
    {
        StringBuilder answerBuilder = new StringBuilder();
        
        answerBuilder.Append(my_string.Substring(0, s));
        answerBuilder.Append(overwrite_string);
        answerBuilder.Append(my_string.Substring(s + overwrite_string.Length));
        
        string answer = answerBuilder.ToString();
        
        return answer;
    }
}