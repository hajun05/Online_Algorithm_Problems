using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static int AlphabetCount(char alphabet, string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == alphabet)
                    count++;
            }
            return count;
        }



        static void Main(string[] args)
        {
            string str = ReadLine();
            if (str.Length >= 1 && str.Length <= 1_000_000)
            {
                str = str.ToUpper();
                int[] max = new int[2] { 0, 0 };
                int cur = 0;
                char alphabet = ' ';
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    cur = AlphabetCount(c, str);
                    if (max[0] < cur)
                    {
                        max[0] = cur;
                        alphabet = c;
                    }
                    else if (max[0] == cur)
                    {
                        max[1] = cur;
                    }
                }
                if (max[0] == max[1])
                    alphabet = '?';

                WriteLine($"{alphabet}");
            }
        }
    }
}
