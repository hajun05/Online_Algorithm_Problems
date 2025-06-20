using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[,] lines)
    {
        int answer = 0;
        
        // 선분 시작점을 기준으로 선분 좌표 오름차순 정렬
        int[][] sortedLines = new int[3][];
        for (int i = 0; i < 3; i++)
        {
            sortedLines[i] = new int[2] { lines[i,0], lines[i,1] };
        }
        sortedLines = sortedLines.OrderBy(x => x[0]).ToArray();

        List<int[]> intersectRanges = new List<int[]>();

        // 겹치는 구간 구하기
        for (int i = 0; i < 2; i++)
        {
            for (int j = i + 1; j < 3; j++)
            {
                if (sortedLines[j][0] < sortedLines[i][1])
                {
                    // 겹치는 구간의 시작점, 끝점
                    int intersectStart = sortedLines[i][0] < sortedLines[j][0]
                        ? sortedLines[j][0] : sortedLines[i][0];
                    int intersectEnd = sortedLines[i][1] < sortedLines[j][1]
                        ? sortedLines[i][1] : sortedLines[j][1];
                    
                    // 겹치는 구간끼리의 중첩 구간 단일화
                    if (intersectRanges.Count == 0 ||
                        intersectRanges[intersectRanges.Count - 1][1] < intersectStart)
                    {
                        intersectRanges.Add(new int[2] { intersectStart, intersectEnd });
                    }
                    else
                    {
                        for (int x = 0; x < intersectRanges.Count; x++)
                        {
                            intersectRanges[x][0] = intersectStart < intersectRanges[x][0]
                                ? intersectStart : intersectRanges[x][0];
                            intersectRanges[x][1] = intersectRanges[x][1] < intersectEnd
                                ? intersectEnd : intersectRanges[x][1];
                        }
                    }
                }
            }
        }
        
        // 겹치는 구간 길이 통합
        foreach (int[] intersectRange in intersectRanges)
        {
            answer += (intersectRange[1] - intersectRange[0]);
        }

        return answer;
    }
}