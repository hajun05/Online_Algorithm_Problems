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

            int N = int.Parse(sr.ReadLine());
            string[] words = new string[N];

            for (int i = 0; i < N; i++)
                words[i] = sr.ReadLine();

            Array.Sort(words, (string str1, string str2) => // Sort(Array, IComparer(람다식))
            {
                if (str1.Length > str2.Length)
                    return 1;
                if (str1.Length < str2.Length)
                    return -1;
                return String.Compare(str1, str2);
            });

            string pre_word = "";
            foreach(string word in words)
            {
                if (pre_word != word)
                {
                    sw.WriteLine(word);
                    pre_word = word;
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}