using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int k, int[] tangerine) 
    {
        int answer = 0;
        
        // 귤의 크기 카테고리별 갯수 계산
        Dictionary<int, int> tangerineSizeCartegory = new Dictionary<int, int>{};
        
        foreach(int size in tangerine)
        {
            if(tangerineSizeCartegory.ContainsKey(size))
            {
                tangerineSizeCartegory[size] += 1;
            }
            else
            {
                tangerineSizeCartegory[size] = 1;
            }
        }
        
        // 귤 k개를 고를 때 크기가 서로 다른 종류의 수의 최솟값 계산
        var DescendingResult = tangerineSizeCartegory.OrderByDescending(x => x.Value);
        int sum = 0;
        foreach (var cartegoryNum in DescendingResult)
        {
            sum += cartegoryNum.Value;
            answer += 1;
            if (sum >= k)
                break;
        }
        
        return answer;
    }
}