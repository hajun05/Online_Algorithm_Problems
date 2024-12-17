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

            //string[] input = sr.ReadLine().Split();
            int N = Convert.ToInt32(sr.ReadLine());

            int n = 0;
            int num = 666;
            while(true)
            {
                string s_num = num.ToString();
                for (int j = s_num.Length - 1; j >= 2; j--)
                {
                    if (s_num[j] == '6' && s_num[j - 1] == '6' && s_num[j - 2] == '6')
                    {
                        n++;
                        if (n == N)
                            goto Print;
                        break;
                    }
                }
                num++;
            }
        Print:
            sw.WriteLine(num);

            sr.Close();
            sw.Close();
        }
    }
}