using System;
using static System.Console;
using System.Collections.Generic;

namespace CsWorkspace
{
    class Program
    {
        static void CheckGroupWord(string word, ref byte count)
        {
            List<char> alphabets = new List<char> { };
            for (int i = 0; i < word.Length; i++)
            {
                if (alphabets.Contains(word[i]))
                    return;
                else
                {
                    alphabets.Add(word[i]);
                    for (int j = 1; i + j < word.Length && word[i + j] == word[i]; i++) ;
                }
            }
            count++;
        }

        static void Main(string[] args)
        {
            byte word_ea = Convert.ToByte(ReadLine());
            string[] words = new string[word_ea];
            for (int i = 0; i < word_ea; i++)
                words[i] = ReadLine().ToLower();
            byte count = 0;

            foreach (string word in words)
                CheckGroupWord(word, ref count);
            WriteLine(count);
        }
    }
}