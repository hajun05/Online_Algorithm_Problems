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

            int N = Convert.ToInt32(sr.ReadLine());
            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
                nums[i] = Convert.ToInt32(sr.ReadLine());

            Array.Sort(nums);

            for (int i = 0; i < N; i++)
                sw.WriteLine(nums[i]);

            sr.Close();
            sw.Close();
        }
    }
}