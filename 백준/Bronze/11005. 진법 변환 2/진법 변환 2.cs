using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            string num_type = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] input = ReadLine().Split();
            int D_num = Convert.ToInt32(input[0]);

            byte B_arithmetic = Convert.ToByte(input[1]);
            string B_num = "";
            
            while(D_num > 0)
            {
                B_num = num_type[D_num % B_arithmetic] + B_num;
                D_num /= B_arithmetic;
            }

            WriteLine(B_num);
        }
    }
}