//Author: Bochen Huang
//FullStack June 2021

using System;

namespace Exercise5
{

    class Program
    {
        public static void BinaryTriangle(int rows)
        {
            int binaryIndex = 0;
            for (int i = 1; i <= rows; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(binaryIndex == 0)
                    {
                        Console.Write("1");
                        binaryIndex = 1;
                    }
                    else if(binaryIndex == 1)
                    {
                        Console.Write("0");
                        binaryIndex = 0;
                    }
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Rows:");
            int userEnter = Convert.ToInt32(Console.ReadLine());

            BinaryTriangle(userEnter);
        }
    }
}
