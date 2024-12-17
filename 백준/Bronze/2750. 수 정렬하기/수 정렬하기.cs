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
            for (int n = 0; n < N; n++)
                nums[n] = Convert.ToInt32(sr.ReadLine());

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            foreach (int num in nums)
                sw.WriteLine(num);

            sr.Close();
            sw.Close();
        }
    }
}