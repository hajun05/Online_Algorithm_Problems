using System;

public class Solution 
{
    public int solution(int n, int m, int[] section) 
    {
        int answer = version1(m, ref section);
        
        return answer;
    }
    
    // 투 포인터 알고리즘 응용. 이중 반복문이지만 배열의 각 요소를 최대 한 번씩만 방문, O(n) 복잡도.
    private int version1(int m, ref int[] section)
    {
        int answer = 0; // 정답
        
        int count = section.Length; // 칠해야하는 구역의 갯수
        int i = 0; // 현재 위치한 칠해야하는 구역의 위치
        while (i < count) // 칠해야하는 구역을 순회
        {
            int j = 1;
            // section[i]위치에서 section[i + j]까지 한번에 칠할수 있는 경우 조회
            while (i + j < count && section[i] + m > section[i + j])
            {
                j++;
            }
            // 조회 종료후 위치한 구역 이동
            i += j;
            // 색칠 횟수 증가
            answer++;
        }
        
        return answer;
    }
}
