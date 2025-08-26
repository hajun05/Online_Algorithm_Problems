using System;

public class Solution 
{
    public int[] solution(string[] keymap, string[] targets) 
    {
        int wordCount = targets.Length;
        int[] answer = new int[wordCount];
        
        for (int i = 0; i < wordCount; i++)
        {
            answer[i] = -1;
            string target = targets[i];
            int wordLength = target.Length;
            
            for (int j = 0; j < wordLength; j++)
            {
                int minIndex = 101;
                
                foreach(string key in keymap)
                {
                    int index = key.IndexOf(target[j]);
                    if (0 <= index && index < minIndex)
                        minIndex = index;
                }
                
                if (minIndex < 101)
                    answer[i] += (minIndex + 1);
                else
                {
                    answer[i] = -1;
                    break;
                }
            }
            
            if (answer[i] > -1)
                answer[i] += 1;
        }
        
        return answer;
    }
}