using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int K = Convert.ToInt32(input[1]);
            List<int> divisors = new List<int>();

            divisors.Add(1);
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                    divisors.Add(i);
            }
            divisors.Add(N);

            if (divisors.Count < K)
                WriteLine(0);
            else
                WriteLine(divisors[K - 1]);
        }
    }
}