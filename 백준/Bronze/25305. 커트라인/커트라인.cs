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

            string[] input = sr.ReadLine().Split();
            int N = Convert.ToInt32(input[0]);
            int k = Convert.ToInt32(input[1]);
            int[] grades = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (grades[i] < grades[j])
                    {
                        int temp = grades[i];
                        grades[i] = grades[j];
                        grades[j] = temp;
                    }
                }
            }

            sw.WriteLine(grades[k - 1]);

            sr.Close();
            sw.Close();
        }
    }
}