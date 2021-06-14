using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Dashboard
    {
        public static void Run()
        {
            int capacity = 10000;
            int numbersOfData = 0;
            HouseholdAccounts householdAccounts = new HouseholdAccounts();
            Menu menu = new Menu();
            int option = (int)CaseOptions.Exit;
            do
            {
                Console.Clear();
                option = menu.Print();
                switch (option)
                {
                    case (int)CaseOptions.Add:
                        householdAccounts.Add();
                        break;
                    case (int)CaseOptions.ShowAll:
                        householdAccounts.ShowAll();
                        break;
                    case (int)CaseOptions.Search:
                        householdAccounts.Search();
                        break;
                    case (int)CaseOptions.Modify:
                        householdAccounts.Modify();
                        break;
                    case (int)CaseOptions.Delete:
                        householdAccounts.Delete();
                        break;
                    case (int)CaseOptions.Sort:
                        householdAccounts.Sort();
                        break;
                    case (int)CaseOptions.Normalize:
                        ManageAccount item = new ManageAccount();
                        householdAccounts.Normalize(item);
                        break;
                    case (int)CaseOptions.Exit:
                        break;
                }
            } while (option != (int)CaseOptions.Exit);
        }
    }
}
