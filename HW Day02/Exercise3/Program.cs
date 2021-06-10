using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Solution solution = new Solution();

            Console.WriteLine("The total number of perfect square is: " + solution.solution(A, B));
        }
    }
}
