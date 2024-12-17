using System;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] white_piece_count = new int[6] { 1, 1, 2, 2, 2, 8 };
            string[] white_piece_find = Console.ReadLine().Split();

            try
            {
                if (white_piece_find.Length != 6)
                    throw new Exception("찾은 피스의 갯수가 올바르지 않습니다.");

                for (int i = 0; i < 6; i++)
                    Console.Write("{0} ", white_piece_count[i] - int.Parse(white_piece_find[i]));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }

        }
    }
}