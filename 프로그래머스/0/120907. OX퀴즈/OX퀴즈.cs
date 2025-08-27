using System;

public class Solution 
{
    public string[] solution(string[] quizs) 
    {
        string[] answer = new string[quizs.Length];
        int X, Y, XY = 0, Z;
        
        for (int i = 0; i < quizs.Length; i++)
        {
            string[] terms = quizs[i].Split();
            int.TryParse(terms[0], out X);
            int.TryParse(terms[2], out Y);
            int.TryParse(terms[4], out Z);
            switch(terms[1])
            {
                case "+":
                XY = X + Y;
                break;
                case "-":
                XY = X - Y;
                break;
            }
            
            if (XY == Z)
                answer[i] = "O";
            else
                answer[i] = "X";
        }
        
        return answer;
    }
}