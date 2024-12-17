using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ReadLine();
            int mid = str.Length / 2;
            int check = 1;
            if (str.Length >= 1 && str.Length <= 100)
            {
                for (int i = 0; i < mid; i++)
                {
                    if (str[i] != str[str.Length - i - 1])
                    {
                        check = 0;
                        break;
                    }
                }
                WriteLine(check);
            }
        }
    }
}
