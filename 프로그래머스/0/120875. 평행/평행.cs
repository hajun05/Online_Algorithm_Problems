using System;

public class Solution 
{
    public int solution(int[,] dots) 
    {
        int answer = 0;
        
        // 기울기를 구할 두 점의 좌표 index 저장 배열. -1은 선택하지 않았단 뜻.
        int[] lean1_dots = new int[2] {0, -1}; // 0번째 점 index는 고정.
        int[] lean2_dots = new int[2] {-1, -1};
        
        // 선을 구성할 점을 한 쌍식 선택
        for (int i = 1; i < dots.GetLength(0); i++)
        {
            // 0, i번째 점 선택
            lean1_dots[1] = i;
            
            // 0, i번째 점 이외의 점 선택
            for (int j = 1; j < dots.GetLength(0); j++)
            {
                if (j != i)
                {
                    lean2_dots[Array.IndexOf(lean2_dots, -1)] = j;
                }
            }
            
            // 선택한 점들로 구성된 두 선의 평행 여부 검사
            double lean1 = (double)(dots[lean1_dots[1], 1] - dots[lean1_dots[0], 1]) / 
                (double)(dots[lean1_dots[1], 0] - dots[lean1_dots[0], 0]);
            double lean2 = (double)(dots[lean2_dots[1], 1] - dots[lean2_dots[0], 1]) / 
                (double)(dots[lean2_dots[1], 0] - dots[lean2_dots[0], 0]);
            
            if (lean1 == lean2)
            {
                answer = 1;
                break;
            }
            else
            {
                lean1_dots[1] = -1;
                Array.Fill(lean2_dots, -1);
            }
        }
        
        return answer;
    }
}