using System;
using System.Text;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        char azLen = (char)('z' - 'a' + 1);
        StringBuilder answer = new StringBuilder();
        
        for (int i = 0; i < s.Length; i++)
        {
            char a = s[i];
            for (int j = 0; j < index; j++)
            {
                a++;
                if (skip.Contains(a))
                {
                    j--;
                    continue;
                }
                if (a > 'z')
                {
                    a -= azLen;
                    if (skip.Contains(a))
                        j--;
                }
            }
            answer.Append(a);
        }
        return answer.ToString();
    }
}