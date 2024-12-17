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

            char[] digits = sr.ReadLine().ToCharArray();
            Array.Sort(digits);
            Array.Reverse(digits);
            sw.WriteLine(digits);

            sr.Close();
            sw.Close();
        }
    }
}