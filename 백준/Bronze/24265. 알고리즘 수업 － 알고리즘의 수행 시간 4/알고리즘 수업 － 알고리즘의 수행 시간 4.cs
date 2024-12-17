using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(ReadLine());
            WriteLine($"{(Math.Pow(n, 2) - n) / 2}\n{2}");
        }
    }
}