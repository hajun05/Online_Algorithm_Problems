using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string[] friends, string[] gifts) 
    {
        // 친구 수
        int friends_num = friends.Length;
        
        // 친구 명단. 친구 이름과 index 매칭
        Dictionary<string, int> friends_dic = new Dictionary<string, int>();
        for (int i = 0; i < friends_num; i++)
            friends_dic.Add(friends[i], i);
        
        // 주고받은 선물 행렬
        int[,] exchange_gifts = new int[friends_num, friends_num];
        // 선물 지수 배열
        int[] gift_index = new int[friends_num];
        
        // 주고받은 선물과 선물 지수 계산
        foreach(string gift in gifts)
        {
            // 선물을 준 사람과 받은 사람, 그 사람들의 index
            string[] gave_received_person = gift.Split();
            int gave_index = friends_dic[gave_received_person[0]];
            int received_index = friends_dic[gave_received_person[1]];
            
            // 주고받은 선물 계산
            exchange_gifts[gave_index, received_index]++;
            
            // 선물 지수 계산
            gift_index[gave_index]++;
            gift_index[received_index]--;
        }
        
        // 다음달 선물 지수
        int[] next_gift_index = new int[friends_num];
        
        // g_i = 선물을 준(gave) 사람의 index / r_i = 선물을 받은(received) 사람의 index
        for (int g_i = 0; g_i < friends_num; g_i++)
        {
            for (int r_i = 0; r_i < g_i; r_i++)
            {
                // 주고받은 선물 행렬에서 주대각선을 기준으로 왼쪽 영역 - 오른쪽 영역.
                // -> 선물을 준 사람과 선물을 받은 사람이 서로에게 전달한 선물의 수를 하나로 합쳐서 취급.
                int n = exchange_gifts[g_i, r_i] - exchange_gifts[r_i, g_i];
                
                if (n > 0) // 선물을 준 사람이 받은 사람보다 더 많이 선물
                    next_gift_index[g_i]++;
                else if (n < 0) // 선물을 받은 사람이 준 사람보다 더 많이 선물
                    next_gift_index[r_i]++;
                else // 각자 서로에게 같은 수의 선물을 선물
                {
                    // 선물을 준 사람과 받은 사람간 총합 선물 전달 지수의 차이
                    n = gift_index[g_i] - gift_index[r_i];
                    if (n > 0) // 선물을 준 사람이 받은 사람보다 더 많이 선물(총합)
                        next_gift_index[g_i]++;
                    else if (n < 0) // 선물을 받은 사람이 준 사람보다 더 많이 선물(총합)
                        next_gift_index[r_i]++;
                }
            }
        }
        
        // 최대값 반환
        int answer = next_gift_index.Max();
        return answer;
    }
}