using System;
using static System.Console;

public class Solution 
{
    public string solution(string video_len, string pos, 
                           string op_start, string op_end, string[] commands) 
    {
        // 동영상 재생 관련 매개변수들을 문자열 -> 숫자 변환[mm], [ss]
        int[] int_video_len = Convert_mmss(video_len);
        int[] int_pos = Convert_mmss(pos);
        int[] int_op_start = Convert_mmss(op_start);
        int[] int_op_end = Convert_mmss(op_end);
        
        foreach(string command in commands)
        {
            // op 건너뛰기
            int_pos = PassOP(int_pos, int_op_start, int_op_end);
            
            // prev, next 이동 명령 처리
            if (command == "prev") // prev 명령
            {
                int_pos[1] -= 10; // 비디오 위치 -10초
                if (int_pos[1] < 0) // 0초를 넘기면
                {
                    int_pos[0] -= 1; // 1분 빼기
                    int_pos[1] += 60; // 초 넘김
                }
            }
            else if (command == "next") // next 명령
            {
                int_pos[1] += 10; // 비디오 위치 +10초
                if (int_pos[1] >= 60) // 60초를 넘기면
                {
                    int_pos[0] += 1; // 1분 추가
                    int_pos[1] -= 60; // 초 넘김
                }
            }

            // 전체 동영상 길이 초과 방지
            if (int_pos[0] * 60 + int_pos[1] >
               int_video_len[0] * 60 + int_video_len[1])
            {
                int_pos[0] = int_video_len[0];
                int_pos[1] = int_video_len[1];
            }
            else if (int_pos[0] * 60 + int_pos[1] < 0)
            {
                int_pos[0] = 0;
                int_pos[1] = 0;
            }
        }
        
        // 마지막 이동 명령 이후 op 건너뛰기.
        int_pos = PassOP(int_pos, int_op_start, int_op_end);
        
        // 이동한 pos를 "mm:ss"형식 문자열로 변환
        string answer = string.Format($"{int_pos[0]:D2}:{int_pos[1]:D2}");
        return answer;
    }
    
    // 동영상 재생 관련 매개변수들을 문자열 -> 숫자 변환[mm], [ss]
    private int[] Convert_mmss(string mmss)
    {
        string[] mm_ss = mmss.Split(':');
        return new int[2] { int.Parse(mm_ss[0]), int.Parse(mm_ss[1]) };
    }
    
    // op 건너뛰기 확인 함수
    private int[] PassOP(int[] cur_pos, int[] op_start, int[] op_end)
    {
        if (cur_pos[0] * 60 + cur_pos[1] <= op_end[0] * 60 + op_end[1] && 
            cur_pos[0] * 60 + cur_pos[1] >= op_start[0] * 60 + op_start[1])
        {
            cur_pos[0] = op_end[0];
            cur_pos[1] = op_end[1];
        }
        
        return cur_pos;
    }
}