using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static bool isPrime(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(ReadLine());
            int[] nums = Array.ConvertAll(ReadLine().Split(), int.Parse);
            int prime_num_ea = 0;

            foreach (int num in nums)
            {
                if (num != 1 && isPrime(num))
                    prime_num_ea++;
            }

            WriteLine(prime_num_ea);
        }
    }
}