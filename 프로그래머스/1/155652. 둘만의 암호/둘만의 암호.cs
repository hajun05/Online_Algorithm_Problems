using System;
using System.Text;
using System.Linq;

public class Solution 
{
    public string solution(string s, string skip, int index) 
    {
        StringBuilder answer = new StringBuilder();
        string a = new string("abcdefghijklmnopqrstuvwxyz".Where(x => !skip.Contains(x)).ToArray());
        foreach(var t in s) 
        {
            answer.Append(a[(a.IndexOf(t.ToString()) + index)%a.Length]);
        }

        return answer.ToString();
    }
}