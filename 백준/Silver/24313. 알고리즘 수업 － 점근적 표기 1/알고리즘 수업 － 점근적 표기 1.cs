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

            int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int c = Convert.ToInt32(sr.ReadLine());
            int n = Convert.ToInt32(sr.ReadLine());

            if (a[0] * n + a[1] <= c * n && c >= a[0])
                sw.WriteLine(1);
            else
                sw.WriteLine(0);

            sr.Close();
            sw.Close();

        }
    }
}