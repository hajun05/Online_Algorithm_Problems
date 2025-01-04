using System;

public class Solution 
{
    public int[] solution(string[] park, string[] routes) 
    {       
        // 명령 수행 후 로봇 강아지의 위치 시작점{상하 열, 좌우 행}
        int[] answer = new int[2] {0, 0};
        
        // 공원의 너비와 높이
        int W = park[0].Length;
        int H = park.Length;
        
        for (int i = 0; i < W; i++)
        {
            int j = park[i].IndexOf("S");
            if (j > -1)
            {
                answer[0] = i;
                answer[1] = j;
            }
        }

        // 방향과 거리 명령 처리. 불가능한 명령이면 생략(continue)
        foreach(string route in routes)
        {
            // "방향 거리" 명령을 "방향", 거리 명령으로 분할.
            string[] route_split = route.Split(' ');
            string dir = route_split[0];
            int dis = int.Parse(route_split[1]);
            
            // 열과 행 둘중 어느 것을 따라 이동하는지, 어느 방향으로 이동하는지 반환
            ChoseDir(dir, out int chose_dir, out int one_step);
            
            // 이동한 방향과 거리
            int move_dis = answer[chose_dir] + (dis * one_step);
            // 이동 거리가 공원을 넘은 경우
            if (move_dis < 0 || move_dis > H - 1 || move_dis > W - 1)
            {
                continue;
            }
            
            // 이동 도중 장애물을 만난 경우
            bool hit_obstacle = false; // 장애물을 만나는지 여부 확인
            // 상하 열(남, 북) 이동
            if (chose_dir == 0)
            {
                for (int i = 1; i <= dis; i++)
                {
                    if (park[answer[0] + i * one_step][answer[1]] == 'X') 
                    {
                        hit_obstacle = true;
                        break;
                    }
                }
            }
            // 좌우 행(동, 서) 이동
            else if (chose_dir == 1)
            {
                for (int i = 1; i <= dis; i++)
                {
                    if (park[answer[0]][answer[1] + i * one_step] == 'X') 
                    {
                        hit_obstacle = true;
                        break;
                    }
                }
            }
            if (hit_obstacle == true)
                continue;
            
            // 이동 방향과 거리 업데이트
            answer[chose_dir] = move_dis;
        }
        
        return answer;
    }
    
    // 명령을 해석해서 어느 방향으로 이동해야하는지 계산하는 메소드
    public void ChoseDir(string dir, out int chose_dir, out int one_step)
    {
        switch(dir)
        {
            case "E": // 동쪽은 좌우, ⭢
                chose_dir = 1;
                one_step = +1;
                break;
            case "W": // 서쪽은 좌우, ⭠
                chose_dir = 1;
                one_step = -1;
                break;
            case "S": // 남쪽은 상하, ⭣
                chose_dir = 0;
                one_step = +1;
                break;
            case "N": // 북쪽은 상하, ⭡
                chose_dir = 0;
                one_step = -1;
                break;
            default: // 불가능한 해석 처리겸 out 매개변수 초기화
                chose_dir = 0;
                one_step = 0;
                break;
        }
    }
}