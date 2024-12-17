using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(OpenStandardInput());
            StreamWriter sw = new StreamWriter(OpenStandardOutput());

            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for (int x = -999; x <= 999; x++)
            {
                for (int y = - 999; y <= 999; y++)
                {
                    if (input[0] * x + input[1] * y == input[2] && input[3] * x + input[4] * y == input[5])
                    {
                        sw.WriteLine($"{x} {y}");
                        break;
                    }
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}