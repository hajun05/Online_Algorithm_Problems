using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static bool isPrime(int num)
        {
            if (num > 1)
            {
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(ReadLine());
            int Q = N;

            if (N > 1)
            {
                for (int factor = 2; factor * factor <= N; factor++)
                {
                    if (Q % factor == 0 && isPrime(factor))
                    {
                        while (Q % factor == 0)
                        {
                            WriteLine(factor);
                            Q /= factor;
                        }
                    }
                }
                if (Q > 1)
                    WriteLine(Q);
            }
        }
    }
}