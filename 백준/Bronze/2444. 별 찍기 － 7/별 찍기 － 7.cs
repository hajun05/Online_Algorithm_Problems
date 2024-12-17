using System;
using static System.Console;
using System.IO;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(OpenStandardInput());
            StreamWriter sw = new StreamWriter(OpenStandardOutput());

            int n = int.Parse(sr.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                    sw.Write(" ");
                for (int j = 0; j < 2 * i - 1; j++)
                    sw.Write("*");
                sw.WriteLine();
            }
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                    sw.Write(" ");
                for (int j = 0; j < 2 * i - 1; j++)
                    sw.Write("*");
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}