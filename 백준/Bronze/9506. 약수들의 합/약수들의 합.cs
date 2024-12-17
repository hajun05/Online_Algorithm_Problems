using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int N = Convert.ToInt32(ReadLine());
                if (N == -1) break;
                string divisors = "1";
                int divisors_sum = 1;

                for (int i = 2; i <= N / 2; i++)
                    if (N % i == 0)
                    {
                        divisors += (" + " + i.ToString());
                        divisors_sum += i;
                    }

                if (N == divisors_sum)
                    WriteLine($"{N} = {divisors}");
                else
                    WriteLine($"{N} is NOT perfect.");
            }
        }
    }
}