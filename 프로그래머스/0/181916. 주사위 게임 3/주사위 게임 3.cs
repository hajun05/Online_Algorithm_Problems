using System;
using System.Linq;

public class Solution 
{
    public int solution(int a, int b, int c, int d) 
    {
        int[] dice = { a, b, c, d };
        // 주사위 값 배열을 정렬, 계산 용이
        Array.Sort(dice);
        
        // 주사위가 모두 같은 경우
        // 크기에 따라 정렬, 가장 작은 값과 큰 값이 같은 경우 == 모두 같은 경우
        if (dice[0] == dice[3]) 
            return 1111 * dice[0];
        
        // 세 주사위가 같은 경우
        if (dice[0] == dice[2]) 
            return (10 * dice[0] + dice[3]) * (10 * dice[0] + dice[3]);
        if (dice[1] == dice[3]) 
            return (10 * dice[1] + dice[0]) * (10 * dice[1] + dice[0]);
        
        // 두 쌍이 각각 같은 경우
        if (dice[0] == dice[1] && dice[2] == dice[3])
            return (dice[0] + dice[2]) * Math.Abs(dice[0] - dice[2]);
        
        // 한 쌍이 같고 나머지가 서로 다른 경우
        if (dice[0] == dice[1])
            return dice[2] * dice[3];
        if (dice[1] == dice[2])
            return dice[0] * dice[3];
        if (dice[2] == dice[3])
            return dice[0] * dice[1];
        
        // 모든 주사위가 다른 경우
        return dice[0];
    }
}