using System;
using System.IO;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(Console.OpenStandardInput());
            StreamWriter w = new StreamWriter(Console.OpenStandardOutput());
            int N = int.Parse(r.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int Cost = int.Parse(r.ReadLine());
                int Q = Cost / 25;
                Cost %= 25;
                int D = Cost / 10;
                Cost %= 10;
                int Ni = Cost / 5;
                Cost %= 5;
                int P = Cost;

                w.WriteLine($"{Q} {D} {Ni} {P}");
            }
            w.Flush();
            w.Close();
            r.Close();
        }
    }
}