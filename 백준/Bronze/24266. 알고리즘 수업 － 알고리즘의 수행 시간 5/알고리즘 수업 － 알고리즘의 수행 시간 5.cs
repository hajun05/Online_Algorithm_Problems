using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt64(ReadLine());
            WriteLine($"{n * n * n}");
            WriteLine($"{3}");
        }
    }
}