using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Menu
    {
       public int Print()
        {
            string[] names = Enum.GetNames(typeof(CaseOptions));
            int[] values = (int[])Enum.GetValues(typeof(CaseOptions));
            int length = names.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Press {values[i]} for {names[i]}");
            }
            //Console.WriteLine("Welcome to Household Accounts");
            //Console.WriteLine("Press 1 for Add a new expense");
            //Console.WriteLine("Press 2 for Show all expenses");
            //Console.WriteLine("Press 3 for Search Costs");
            //Console.WriteLine("Press 4 for Modify a tab");
            //Console.WriteLine("Press 5 for Delete some data");
            //Console.WriteLine("Press 6 for Sort Data");
            //Console.WriteLine("Press 7 for Normalize descriptions");
            //Console.WriteLine("Press 8 for Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
