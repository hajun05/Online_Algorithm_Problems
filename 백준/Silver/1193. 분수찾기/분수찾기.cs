using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(ReadLine());

            int i = 1, sum = 1;
            for (; sum + i <= n; sum += i, i++) ;

            if (i % 2 == 0)
                WriteLine($"{1 + (n - sum)}/{i - (n - sum)}");
            else
                WriteLine($"{i - (n - sum)}/{1 + (n - sum)}");
        }
    }
}