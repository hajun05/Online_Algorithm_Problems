using System;
using System.IO;
using System.Linq;
using static System.Console;

namespace Beakjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //첫째 줄에 상근이가 가지고 있는 숫자 카드의 개수 N(1 ≤ N ≤ 500, 000)이 주어진다.
            //둘째 줄에는 숫자 카드에 적혀있는 정수가 주어진다.
            //숫자 카드에 적혀있는 수는 -10,000,000보다 크거나 같고, 10,000,000보다 작거나 같다.
            //두 숫자 카드에 같은 수가 적혀있는 경우는 없다.
            //셋째 줄에는 M(1 ≤ M ≤ 500, 000)이 주어진다.
            //넷째 줄에는 상근이가 가지고 있는 숫자 카드인지 아닌지를 구해야 할 M개의 정수가 주어지며, 이 수는 공백으로 구분되어져 있다.
            //이 수도 -10,000,000보다 크거나 같고, 10,000,000보다 작거나 같다

            // 입출력 시간 절약을 위한 스트림 생성
            StreamReader sr = new StreamReader(OpenStandardInput());
            StreamWriter sw = new StreamWriter(OpenStandardOutput());

            // N(소유한 숫자 카드 갯수) 입력
            int N = int.Parse(sr.ReadLine());

            // 상근이가 가진 숫자 카드에 적혀있는 정수 입력
            //long[] Sang_geun_num_cards = new long[N];
            //Sang_geun_num_cards = sr.ReadLine().Split().Select(long.Parse).ToArray();
            //HashSet 활용 버전
            HashSet<int> Sang_geun_num_cards = new HashSet<int>(N);
            long[] temp_num_cards = sr.ReadLine().Split().Select(long.Parse).ToArray();
            foreach (int num in temp_num_cards)
            {
                Sang_geun_num_cards.Add(num);
            }

            // M(소유 여부 확인 숫자 카드 갯수) 입력
            int M = int.Parse(sr.ReadLine());

            // 상근이가 가지고 있는 숫자 카드인지 구해야할 숫자 카드 입력
            long[] num_cards = new long[M];
            num_cards = sr.ReadLine().Split().Select(long.Parse).ToArray();

            // v3 상근이가 가지고 있는 숫자 카드인지 아닌지를 계산
            // HashSet 활용
            foreach (int num in num_cards)
            {
                if (Sang_geun_num_cards.Contains(num))
                {
                    sw.Write("1 ");
                }
                else
                {
                    sw.Write("0 ");
                }
            }

            //// v2 상근이가 가지고 있는 숫자 카드인지 아닌지를 계산
            //// 이진탐색 구현, 낮은 시간복잡도
            //// 근데도 시간 초과라네... -> string +=  출력 방식의 문제!
            //Array.Sort(Sang_geun_num_cards);

            //foreach (int num in num_cards)
            //{
            //    //직업 이진탐색. 이진 탐색을 위한 탐색 범위 index 설정
            //    int first = 0;
            //    int last = Sang_geun_num_cards.Length - 1;
            //    int middle = (first + last) / 2;

            //    while (true)
            //    {
            //        //이진 탐색
            //        if (num < Sang_geun_num_cards[middle])
            //        {
            //            last = middle - 1; // middle이 아니었으니 -1
            //            middle = (first + last) / 2;
            //        }
            //        else if (Sang_geun_num_cards[middle] < num)
            //        {
            //            first = middle + 1; // middle이 아니었으니 +1
            //            middle = (first + last) / 2;
            //        }
            //        else // 탐색 성공
            //        {
            //            sw.Write("1 ");
            //            break;
            //        }
            //        if (first > last) // 탐색 실패
            //        {
            //            sw.Write("0 ");
            //            break;
            //        }
            //    }

            //    // 이진탐색 메소드 사용
            //    if (Array.BinarySearch(Sang_geun_num_cards, num) < 0)
            //    {
            //        result += "0 ";
            //    }
            //    else
            //    {
            //        result += "1 ";
            //    }
            //}

            //// v1 상근이가 가지고 있는 숫자 카드인지 아닌지를 계산
            //// Contains 순차탐색, 높은 시간복잡도
            //foreach (int num in num_cards)
            //{
            //    if(Sang_geun_num_cards.Contains(num))
            //    {
            //        result += "1 ";
            //    }
            //    else
            //    {
            //        result += "0 ";
            //    }
            //}

            // 입출력 스트림 닫기
            sw.Flush();
        }
    }
}