using System;

public class Solution 
{
    public int solution(int[] common) 
    {
        int answer = common[common.Length - 1];

        bool isGS;
        isGS = (common[1] - common[0] == common[2] - common[1]) ? false : true;
        
        if(!isGS) 	
            answer += (common[1] - common[0]);
        else 		
            answer *= (common[1]/common[0]);
        
        return answer;
    }
}