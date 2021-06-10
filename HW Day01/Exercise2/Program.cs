//Author: Bochen Huang
//FullStack June 2021

using System;

namespace Exercise2
{
    public class Arithmetic
    {
        int a = 55;
        int b = 5;

        public void AddTwoNumbers()
        {
            int c = 0;
            c = a + b;
            Console.WriteLine(c);
        }

        public void SubtractTwoNumbers()
        {
            int c = 0;
            c = a - b;
            Console.WriteLine(c);
        }

        public void MultiplicateTwoNumbers()
        {
            int c = 0;
            c = a * b;
            Console.WriteLine(c);
        }

        public void DivideTwoNumbers()
        {
            int c = 0;
            c = a / b;
            Console.WriteLine(c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();

            Console.WriteLine("Input your choice:");
            Console.WriteLine("Input 1 for Addition result;");
            Console.WriteLine("Input 2 for Subtraction result;");
            Console.WriteLine("Input 3 for Multiplication result;");
            Console.WriteLine("Input 4 for Division result.");

            int switchCase = Convert.ToInt32(Console.ReadLine());

            switch (switchCase)
            {
                case 1:
                    Console.WriteLine("The Addition result is:");
                    arithmetic.AddTwoNumbers();
                    break;

                case 2:
                    Console.WriteLine("The Subtraction result is:");
                    arithmetic.SubtractTwoNumbers();
                    break;
                case 3:
                    Console.WriteLine("The Multiplication result is:");
                    arithmetic.MultiplicateTwoNumbers();
                    break;
                case 4:
                    Console.WriteLine("The Division result is:");
                    arithmetic.DivideTwoNumbers();
                    break;
            }
        }
    }
}
