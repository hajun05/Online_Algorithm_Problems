using static System.Console;
using System.IO;
using System.Linq;

namespace Beakjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // 수직선 위에 N개의 좌표 X1, X2, ..., XN이 있다. 이 좌표에 좌표 압축을 적용하려고 한다.
            // Xi를 좌표 압축한 결과 X'i의 값은 Xi > Xj를 만족하는 서로 다른 좌표 Xj의 개수와 같아야 한다.
            // X1, X2, ..., XN에 좌표 압축을 적용한 결과 X'1, X'2, ..., X'N를 출력해보자.

            // 입출력 시간 절약을 위한 스트림 생성
            StreamReader sr = new StreamReader(OpenStandardInput());
            StreamWriter sw = new StreamWriter(OpenStandardOutput());

            // 좌표 갯수 입력
            int N = int.Parse(sr.ReadLine());

            // 좌표 저장
            // LINQ 퀴리식을 이용해 문자열 -> 문자열 배열 -> 숫자 배열 즉각 변환
            int[] XN = sr.ReadLine().Split().Select(int.Parse).ToArray();

            // 좌표 압축 v1 : 최소값을 지닌 좌표를 0, 큰 순서대로 +1 하는 식으로 축약
            // 시간 소모 과다
            //int[] compressed_XN = new int[N]; // 압축될 좌표 저장 배열
            //for (int i = 0; i < N - 1; i++)
            //{
            //    //compressed_XN[i] = 0;
            //    for (int j = i + 1; j < N; j++)
            //    {
            //        if (XN[i] > XN[j])
            //        {
            //            compressed_XN[i]++;
            //        }
            //        else if (XN[i] < XN[j]) 
            //        {
            //            compressed_XN[j]++; 
            //        }
            //    }
            //}

            // 좌표 압축 v2
            // 1. 중복값 제거를 위해 크기를 임의로 조절 가능한 List
            // 2. <XN[i] - XN[i]의 크기 순위> 매칭을 위한 Dictionary

            // 좌표 중복값 정리 v1. Contains 사용
            //List<int> XN_list = new List<int>();
            //foreach (int x in XN)
            //{
            //    if (XN_list.Contains(x))
            //        continue;
            //    XN_list.Add(x);
            //}
            //XN_list.Sort();

            // 좌표 중복값 정리 v2. LINQ 메소드식 사용
            List<int> XN_list = XN.Distinct().ToList();
            XN_list.Sort();

            // <좌표값 - 좌표값 크기 순위> 매칭
            Dictionary<int, int> compressed_XN = new Dictionary<int, int>();
            for (int i = 0; i < XN_list.Count; i++)
            {
                compressed_XN[XN_list[i]] = i;
            }
            // 압축된 좌표 출력
            for (int i = 0; i < N; i++)
            {
                sw.Write(compressed_XN[XN[i]] + " ");
            }

            // 입출력 스트림 닫기
            sw.Close();
        }
    }
}
