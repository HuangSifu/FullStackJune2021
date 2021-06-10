//Author: Bochen Huang
//FullStack June 2021

using System;

namespace Exercise4
{
    class Program
    {
        public static void Armstrong(int start, int end)
        {
            int sum, basic, temp;
            for (int i = start; i <= end; i++)
            {
                temp = i;
                sum = 0;
                while(temp != 0)
                {
                    basic = temp % 10;
                    temp = temp / 10;
                    sum = sum + (basic * basic * basic);
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int end = Convert.ToInt32(Console.ReadLine());

            Armstrong(start, end);
        }
    }
}
