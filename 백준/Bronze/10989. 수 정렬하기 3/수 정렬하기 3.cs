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

            int count = Convert.ToInt32(sr.ReadLine());
            int[] list = new int[10000];

            for (int i = 0; i < count; i++)
                list[int.Parse(sr.ReadLine()) - 1]++;

            for (int i = 0; i < 10000; i++)
                if (list[i] != 0)
                    for (int j = 0; j < list[i]; j++)
                        sw.WriteLine(i + 1);

            sr.Close();
            sw.Close();
        }
    }
}