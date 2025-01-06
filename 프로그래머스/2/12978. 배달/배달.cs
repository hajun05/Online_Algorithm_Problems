using System;
using System.Collections.Generic;

// 그래프 edge 정보 구조체. 연결점, 가중치
public struct Edge
{
    public int vertex;
    public int weight;
    public Edge(int v, int w)
    {
        vertex = v;
        weight = w;
    }
}

class Solution
{
    // 그래프 자료구조 필드
    private List<Edge>[] graph;
    
    // road 행렬을 그래프 자료구조화()
    public void Gragh(ref int[,] road, int N)
    {
        // 그래프 자료구조화<연결된 마을, 가중치>[마을 갯수] 초기화
        graph = new List<Edge>[N];
        for (int i = 0; i < N; i++)
        {
            graph[i] = new List<Edge>();
        }
        
        // 2차원 road -> List 그래프 변환. (연결된 마을, 가중치)
        int n = road.GetLength(0);
        for(int i = 0; i < n; i++)
        {
            // 양방향 그래프. 마을은 1번부터, index는 0번부터 시작하기 때문에 -1
            graph[road[i,0] - 1].Add(new Edge(road[i,1] - 1, road[i,2]));
            graph[road[i,1] - 1].Add(new Edge(road[i,0] - 1, road[i,2]));
        }
    }
    
    // 다익스트라 활용, 배달이 가능한 마을의 개수 return 메소드
    public int Dijikstra(int start, int N, int K)
    {
        // 배달이 가능한 마을의 개수(시작 마을 기본 추가)
        int answer = 1;
        
        bool[] visited = new bool[N]; // 각 노드 방문 여부
        int[] parent = new int[N]; // 각 노드들의 부모 노드. 가장 빠른 경로를 따라 배정
        int[] distance = new int[N]; // 출발점으로부터 각 노드까지의 거리
        Array.Fill(distance, Int32.MaxValue); // int형 최대값(아직 거리 측정 X 표시)
        
        distance[start] = 0; // 시작점이기에 거리 0
        
        // 시작점을 미리 방문처리 해버리면 시작점 예약 생략, 바로 다익스트라 계산 종료
        //visited[start] = true; // 시작점 방문 처리
        //parent[start] = start; // 시작점의 부모를 시작점으로 처리
        
        // 다익스트라 계산
        while (true)
        {
            int closest = Int32.MaxValue; // 예약할 노드의 거리 저장
            int now = -1; // 예약할 노드의 번호 저장
            
            // 예약할 노드 탐색. 노드들(마을) 순회이기 때문에 List형도 for문 사용
            for (int i = 0; i < N; i++)
            {
                // 방문하지 않음 & 과거에 최단 경로 계산 & 새로 구한 최단 경로가 기존 경로보다 짧은 경우 노드 예약 
                if (!visited[i] && distance[i] != Int32.MaxValue && distance[i] < closest)
                {
                    closest = distance[i]; // 새로 찾은 정점 예약 혹은 갱신
                    now = i;
                }
            }
            
            if (now == -1) // 모든 노드 방문, 거리 측정 완료시 루프 탈출
                break;
            
            visited[now] = true; // 예약한 노드 방문
            foreach(Edge node in graph[now])
            {
                // 현재 노드와 연결된 다음 노드.
                int next = node.vertex;
                
                if (!visited[next]) // 방문 X, 예약한 정점과 연결된 정점 순회
                {
                    int nextdist = distance[now] + node.weight; // 탐색한 정점까지 최단 경로 계산
                    // (distance[next] 거리 측정 X || 새 최단 경로가 기존보다 작음)
                    if (nextdist < distance[next]) 
                    {
                        distance[next] = nextdist; // 최단 경로 저장 || 갱신
                        parent[next] = now;
                    }
                }
            }
        }
        
        // 음식 주문 가능한 마을 갯수 개산
        for(int i = 1; i < N; i++)
        {
            Console.Write("{0} ", distance[i]);
            if (distance[i] <= K)
                answer++;
        }
        
        return answer;
    }
    
    public int solution(int N, int[,] road, int K)
    {
        // road -> graph 자료구조 변환
        Gragh(ref road, N);
        
        // 그래프 노드 방문
        int answer = Dijikstra(0, N, K);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        System.Console.WriteLine(answer);

        return answer;
    }
}