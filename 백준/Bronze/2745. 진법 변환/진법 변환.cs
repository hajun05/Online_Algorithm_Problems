using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static int Pow(int _base, int n)
        {
            int pow = 1;
            for (int i = 0; i < n; i++)
                pow *= _base;
            return pow;
        }

        static void Main(string[] args)
        {
            string[] input = ReadLine().Split();
            string B_num = input[0];
            byte B_arithmetic = Convert.ToByte(input[1]);
            int D_num = 0;

            for (int i = 0, digit = 0; i < B_num.Length; i++)
            {
                if (B_num[i] >= '0' && B_num[i] <= '9')
                {
                    digit = (B_num[i] - '0');
                }
                else if (B_num[i] >= 'A' && B_num[i] <= 'Z')
                {
                    digit = (B_num[i] - 'A' + 10);
                }
                D_num += digit * Pow(B_arithmetic, (B_num.Length - i - 1));
            }

            WriteLine(D_num);
        }
    }
}