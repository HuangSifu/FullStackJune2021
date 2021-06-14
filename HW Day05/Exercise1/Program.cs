using System;

namespace Exercise1
{

    class Program
    {
        public static int Add(int num1, int num2)
        {
            int sum, carry;
            do
            {
                sum = num1 ^ num2;
                carry = (num1 & num2) << 1; 
                num1 = sum;
                num2 = carry;
            } while (num2 != 0);
            return num1;
        }
        public static int pow(int a, int b)
        {
            if (b == 0)
                return 1;
            int answer = a;
            int increment = a;
            int i, j;
            for (i = 1; i < b; i++)
            {
                for (j = 1; j < a; j++)
                {
                    answer = Add(answer,increment);
                }
                increment = answer;
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number=> ");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = pow(a, 2);
            Console.WriteLine("{0}", result);

        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number=> ");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    if (a > 0 && a <= 10)
        //    {
        //        for (int i = 0; i < 6; i++)
        //        {
        //            a = a << 1;
        //            Console.WriteLine("{0}", a);

        //        }
        //    }
        //    Console.ReadKey();
        //}
    }
}
