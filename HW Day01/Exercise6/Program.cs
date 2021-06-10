//Author: Bochen Huang
//FullStack June 2021

using System;

namespace Exercise6
{
    class Program
    {
        public static void PrintDiamond(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 0; j < rows - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows:");
            int userEnter = Convert.ToInt32(Console.ReadLine());

            PrintDiamond(userEnter);
        }
    }
}
