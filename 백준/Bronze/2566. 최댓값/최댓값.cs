using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] arr = new byte[9,9];
            byte max = 0;
            byte[] max_index = new byte[2];

            for (int i = 0; i < 9; i++)
            {
                string[] str = ReadLine().Split();
                for (int j = 0; j < 9; j++)
                {
                    arr[i,j] = Convert.ToByte(str[j]);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (max < arr[i,j])
                    {
                        max = arr[i,j];
                        max_index = new byte[]{ (byte)i, (byte)j };
                    }
                }
            }

            WriteLine("{0}\n{1} {2}", max, max_index[0] + 1, max_index[1] + 1);
        }
    }
}