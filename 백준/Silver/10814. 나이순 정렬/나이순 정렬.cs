using System;
using System.IO;

namespace CsWorkspace
{
    public struct JedgeMem
    {
        public int age;
        public string name;
        public int order;
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine());
            JedgeMem[] mem = new JedgeMem[N];

            for (int i = 0; i < N; i++)
            {
                string[] input = sr.ReadLine().Split();
                mem[i].age = int.Parse(input[0]);
                mem[i].name = input[1];
                mem[i].order = i;
            }

            Array.Sort(mem, (JedgeMem mem1, JedgeMem mem2) =>
            {
                if (mem1.age > mem2.age)
                    return 1;
                if (mem1.age < mem2.age)
                    return -1;
                return mem1.order >= mem2.order ? 1 : -1;
            });

            for (int i = 0; i < N; i++)
                sw.WriteLine($"{mem[i].age} {mem[i].name}");

            sr.Close();
            sw.Close();
        }
    }
}