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
                string[] input = ReadLine().Split();
                int A = Convert.ToInt32(input[0]);
                int B = Convert.ToInt32(input[1]);

                if (A == 0 || B == 0)
                    break;
                else if (B % A == 0)
                    WriteLine("factor");
                else if (A % B == 0)
                    WriteLine("multiple");
                else
                    WriteLine("neither");
            }
        }
    }
}