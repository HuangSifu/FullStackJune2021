//Author: Bochen Huang
//FullStack June 2021

using System;

namespace Exercise3
{
    class Program
    {

        public static string ReverseString(string str)
        {
            char[] strArray = str.ToCharArray();
            string reversedString = String.Empty;
            for (int i = strArray.Length - 1; i > -1 ; i--)
            {
                reversedString += strArray[i];
            }
            return reversedString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string you want to reverse: ");
            String userEnter = Console.ReadLine();

            Console.WriteLine("The reversed string is: ");
            Console.WriteLine(ReverseString(userEnter));
        }
    }
}
