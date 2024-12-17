using System;
using static System.Console;

namespace CsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] tri_edges = Array.ConvertAll(ReadLine().Split(), int.Parse);
                int max = 0;
                foreach (int edge in tri_edges)
                {
                    if (max < edge)
                        max = edge;
                }

                if (tri_edges[0] == 0 && tri_edges[1] == 0 && tri_edges[2] == 0)
                    return;
                else if (max >= tri_edges[0] + tri_edges[1] || max >= tri_edges[1] + tri_edges[2] || max >= tri_edges[0] + tri_edges[2])
                    WriteLine("Invalid");
                else if (tri_edges[0] == tri_edges[1] && tri_edges[1] == tri_edges[2] && tri_edges[0] == tri_edges[2])
                    WriteLine("Equilateral");
                else if (tri_edges[0] == tri_edges[1] || tri_edges[1] == tri_edges[2] || tri_edges[0] == tri_edges[2])
                    WriteLine("Isosceles");
                else
                    WriteLine("Scalene");
            }
        }
    }
}