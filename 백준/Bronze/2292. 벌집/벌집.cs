using System;
using static System.Console;
using System.IO;

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
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int n = Convert.ToInt32(sr.ReadLine());
            int num = 1;
            
            for (int i = 0; ; i++)
            {
                num += (6 * i);
                if (num >= n)
                {
                    sw.WriteLine(i + 1);
                    break;
                }
            }
            
            sr.Close();
            sw.Close();
        }
    }
}