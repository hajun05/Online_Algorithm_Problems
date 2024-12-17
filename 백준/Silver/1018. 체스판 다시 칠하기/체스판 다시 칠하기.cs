using System;
using static System.Console;
using System.IO;

namespace CsWorkspace
{
    class Program
    {
        static int RePaint(int N, int M, string[] board)
        {
            int min = 64;
            string[] board_color = { "WBWBWBWB", "BWBWBWBW" };

            for (int n = 0; N - n >= 8; n++)
            {
                for (int m = 0; M - m >= 8; m++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        int temp = 0;
                        int k = c;
                        for (int i = 0; i < 8; i++, k = (k + 1) % 2)
                        {
                            for (int j = 0; j < 8; j++)
                                if (board[i + n][j + m] != board_color[k][j])
                                    temp++;
                        }
                        if (min > temp)
                            min = temp;
                    }
                }
            }
            
            return min;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(OpenStandardInput());
            StreamWriter sw = new StreamWriter(OpenStandardOutput());

            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int N = input[0];
            int M = input[1];

            string[] chessboard = new string[N];
            for (int i = 0; i < N; i++)
                chessboard[i] = sr.ReadLine();

            sw.WriteLine(RePaint(N, M, chessboard));

            sr.Close();
            sw.Close();
        }
    }
}