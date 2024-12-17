using System;
using System.IO;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Convert.ToInt32(sr.ReadLine());
            (int y, int x)[] coor = new (int x, int y)[N]; // 튜플
            for (int i = 0; i < N; i++)
            {
                string[] input = sr.ReadLine().Split();
                coor[i] = (int.Parse(input[1]), int.Parse(input[0]));
            }

            Array.Sort(coor);

            foreach ((int y, int x) point in coor)
                sw.WriteLine($"{point.x} {point.y}");

            sr.Close();
            sw.Close();
        }
    }
}