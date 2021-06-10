//Author: Bochen Huang
//FullStack June 2021
using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9} };

            Solution solution = new Solution();
            solution.Take2DToSpiral(A);
        }
    }
}
