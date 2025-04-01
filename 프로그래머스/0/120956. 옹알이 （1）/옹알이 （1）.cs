using System;
using System.Text.RegularExpressions;

public class Solution 
{
    public int solution(string[] babbling) 
    {
        int answer = 0;

        // 정규 표현식: "aya", "ye", "woo", "ma"로만 이루어진 문자열을 매칭
        string pattern = @"^(aya|ye|woo|ma)+$";
        Regex regex = new Regex(pattern);

        foreach (string word in babbling)
        {
            // 중복된 발음 방지: "ayaaya", "yeye" 등
            if (regex.IsMatch(word) && !HasConsecutiveRepeats(word))
            {
                answer++;
            }
        }

        return answer;
    }

    // 중복된 발음이 있는지 확인하는 메서드
    private bool HasConsecutiveRepeats(string word)
    {
        string[] talkable = { "aya", "ye", "woo", "ma" };
        foreach (string able in talkable)
        {
            if (word.Contains(able + able))
            {
                return true; // 중복된 발음이 있음
            }
        }
        return false; // 중복된 발음이 없음
    }
}