using System;
using System.Text;

public class Solution 
{
    public string solution(string X, string Y) 
    {
        int[] countX = new int[10];
        int[] countY = new int[10];

        // X, Y 각 숫자별 등장 횟수 카운트
        foreach (char c in X) countX[c - '0']++;
        foreach (char c in Y) countY[c - '0']++;

        StringBuilder sb = new StringBuilder();

        // 9부터 0까지 내림차순으로, 최소 등장 횟수만큼 추가
        for (int i = 9; i >= 0; i--)
        {
            int minCount = Math.Min(countX[i], countY[i]);
            sb.Append(new string((char)('0' + i), minCount));
        }

        string answer = sb.ToString();
        if (answer == "") return "-1";
        if (answer[0] == '0') return "0"; // 0만 여러개인 경우

        return answer;
    }
}