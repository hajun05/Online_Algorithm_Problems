using System;

public class Solution 
{
    public int[,] solution(int[,] arr) 
    {   
        int rowLength = arr.GetLength(0);
        int colLength = arr.Length / arr.GetLength(0);
        int longgerLength = rowLength > colLength ? rowLength : colLength;
        
        int[,] answer = new int[longgerLength, longgerLength];
        for(int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                answer[i,j] = arr[i,j];
            }
        }
        
        return answer;
    }
}