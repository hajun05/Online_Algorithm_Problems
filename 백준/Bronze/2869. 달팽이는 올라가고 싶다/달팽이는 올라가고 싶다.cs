using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static int Ceil(double num)
        {
            if (num % 1 > 0)
                return (int)num + 1;
            return (int)num;
        }

        static void Main(string[] args)
        {
            string[] input = ReadLine().Split();
            int A = Convert.ToInt32(input[0]);
            int B = Convert.ToInt32(input[1]);
            int V = Convert.ToInt32(input[2]);
            int day = Ceil((double)(V - A) / (A - B)) + 1;
            WriteLine(day);
        }
    }
}