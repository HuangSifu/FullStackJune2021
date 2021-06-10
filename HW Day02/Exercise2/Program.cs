using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[length];
            Console.WriteLine("Please enter values of the array: ");
            for (int i = 0; i < length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Solution solution = new Solution();

            Console.WriteLine(solution.solution(A));
        }
    }
}
