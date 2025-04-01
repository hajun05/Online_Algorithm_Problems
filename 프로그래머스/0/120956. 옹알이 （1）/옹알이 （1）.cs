using System;

public class Solution 
{
    public int solution(string[] babbling) 
    {
        int answer = 0;
        string[] talkable = { "aya", "ye", "woo", "ma" };
        for (int i = 0; i < babbling.Length; i++) 
        {
            string word = babbling[i];
            foreach (string able in talkable)
            {
                word = word.Replace(able, " ");
                if(string.IsNullOrWhiteSpace(word))
                {
                    answer++;
                    break;
                }
            }
            
        }

        return answer;
    }
}