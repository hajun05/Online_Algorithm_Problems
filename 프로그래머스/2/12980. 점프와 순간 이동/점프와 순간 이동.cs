using System;

class Solution
{
    // 0 -> n이 아닌 n -> 0 반대 방향 계산. 때론 반대로 생각하는게 쉬운 정답!
    // 이진 표현에서 1의 개수를 세는 알고리즘
    public int solution(int n)
    {
        int answer = 0;

        while(n > 0)
        {
            if (n % 2 > 0)
                answer++;
            
            n /= 2;
        }

        return answer;
    }
}