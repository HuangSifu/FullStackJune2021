//Author: Bochen Huang
//FullStack June 2021

using System;

namespace Exercise7
{
    class Program
    {

        /*public static int CheckBalance(int balance)
        {
            return balance;
        }

        public static int Withdraw(int balance, int withdraw)
        {
            return balance - withdraw;
        }

        public static int Deposite(int balance,int depo)
        {
            return balance + depo;
        }
        */
        static void Main(string[] args)
        {
            int balance = 1000;
            int deposite, withdraw;
            int switchCase;

            Console.WriteLine("Enter Your Pin Number:");
            int pin = Convert.ToInt32(Console.ReadLine());

            if(pin == 123)
            {
                Console.WriteLine("********Welcome to ATM Service**************");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Quit");
                Console.WriteLine("*********************************************");

                Console.WriteLine("Enter your choice:");

                switchCase = Convert.ToInt32(Console.ReadLine());

                switch (switchCase)
                {
                    case 1:
                        Console.WriteLine("YOUR BALANCE IN RS:" + balance);
                        break;
                    case 2:
                        Console.WriteLine("ENTER THE AMOUNT YOU WANT TO WITHDRAW:");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        balance = balance - withdraw;
                        Console.WriteLine("YOUR CURRENT BALANCE IN RS AFTER WITHDRAW:" + balance);
                        break;
                    case 3:
                        Console.WriteLine("ENTER THE AMOUNT YOU WANT TO DEPOSITE:");
                        deposite = Convert.ToInt32(Console.ReadLine());
                        balance = balance + deposite;
                        Console.WriteLine("YOUR BALANCE IN RS AFTER DEPOSITE:" + balance);
                        break;
                    case 4:
                        Console.WriteLine("THANKS FOR USING ATM. SEE YOU NEXT TIME.");
                        break;
                
                }
            }
            else
            {
                Console.WriteLine("INVALID PIN NUMBER.");
            }

        }
    }
}
