using System;

public class Solution 
{
    public int solution(int[] schedules, int[,] timelogs, int startday) 
    {
        int answer = schedules.Length;
        
            for (int j = 0; j < schedules.Length; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    if ((startday + i) % 7 == 6 || (startday + i) % 7 == 0)
                        continue;
                    
                    int limit = schedules[j];
                    if ((limit + 10) % 100 >= 60)
                        limit = ((limit / 100 + 1) * 100) + ((limit + 10) % 100 - 60);
                    else
                        limit += 10;
                    
                    if (limit < timelogs[j,i])
                    {
                        answer--;
                        break;
                    }
                }
            }
        
        return answer;
    }
}