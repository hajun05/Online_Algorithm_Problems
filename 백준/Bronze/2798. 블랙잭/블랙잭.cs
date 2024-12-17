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
        static long BlackJack(int[] arr, int n, int m)
        {
            long result = 0;

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        int temp = arr[i] + arr[j] + arr[k];
                        if (temp == m)
                            return temp;
                        else if (temp < m && result < temp)
                            result = temp;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(OpenStandardInput());
            StreamWriter sw = new StreamWriter(OpenStandardOutput());

            string[] input_num = ReadLine().Split();
            int N = Convert.ToInt32(input_num[0]);
            int M = Convert.ToInt32(input_num[1]);
            
            int[] cards = new int[N];
            string[] input_cards = ReadLine().Split();
            for (int i = 0; i < N; i++)
                cards[i] = Convert.ToInt32(input_cards[i]);

            long sum = BlackJack(cards, N, M);
            if (sum != 0)
                sw.WriteLine(sum);

            sr.Close();
            sw.Close();
        }
    }
}