using System;
using static System.Console;
using System.IO;

namespace CsWorkspace
{
    class Program
    {
        static int Digit_sum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += (num % 10);
                num /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(OpenStandardInput());
            StreamWriter sw = new StreamWriter(OpenStandardOutput());

            int N = Convert.ToInt32(ReadLine());

            int decompose = 0;
            for (int n = 1; n < N; n++)
            {
                int digit_sum = Digit_sum(n);
                if (n + digit_sum == N)
                {
                    decompose = n;
                    break;
                }
            }
            sw.WriteLine(decompose);

            sr.Close();
            sw.Close();
        }
    }
}