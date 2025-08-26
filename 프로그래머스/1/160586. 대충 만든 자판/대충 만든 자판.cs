using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) 
    {
        // dictionary에 최소값으로 넣어줌
        var dict = new Dictionary<char, int>();
        for(int i = 0; i < keymap.Length; i++)
        {
            string keyStr = keymap[i];
            for(int k = 0; k < keyStr.Length; k++)
            {
                char c = keyStr[k];
                dict[c] = dict.ContainsKey(c) ? Math.Min(k, dict[c]) : k;
            }
        }

        // dictionary에서 검색 후 출력
        int[] answer = new int[targets.Length];
        for(int i = 0; i < targets.Length; i++)
        {
            string targetStr = targets[i];
            for(int k = 0; k < targetStr.Length; k++)
            {
                if(!dict.TryGetValue(targetStr[k], out int index))
                {
                    answer[i] = -1;
                    break;
                }

                answer[i] += index + 1;
            }
        }

        return answer;
    }
}