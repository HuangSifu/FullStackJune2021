using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class HouseholdAccounts
    {
        //public int Id { get; set; }
        //public string Date { get; set; }
        //public string Description { get; set; }
        //public string Category { get; set; }
        //public double Amount { get; set; }

        List<ManageAccount> accountsCollection = new List<ManageAccount>();

        public void Add()
        {
            ManageAccount manageAccount = new ManageAccount();
            Console.Write("Enter Id = ");
            manageAccount.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Date in YYYYMMDD format = ");
            manageAccount.Date = Console.ReadLine();
            Console.Write("Enter Description = ");
            manageAccount.Description = Console.ReadLine();
            Console.Write("Enter Category = ");
            manageAccount.Category = Console.ReadLine();
            Console.Write("Enter Amount = ");
            manageAccount.Amount =Convert.ToDouble(Console.ReadLine());

            accountsCollection.Add(manageAccount);
        }
        public void ShowAll()
        {
            foreach(ManageAccount item in accountsCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Date + "\t" + item.Description +
                    "\t" + item.Category + "\t" + item.Amount + "\t");
            }

        }

        public void Search()
        {
            ManageAccount item = new ManageAccount();

            int length = accountsCollection.Count;
            Console.WriteLine("Enter the text you want to search: ");
            string input = Console.ReadLine();

            for (int i = 0; i < length; i++)
            {
                if (accountsCollection[i].Description == input || accountsCollection[i].Category == input)
                {
                    item = accountsCollection[i];
                    Console.WriteLine(item.Id + "\t" + item.Date + "\t" + item.Description +
                     "\t" + item.Category + "\t" + item.Amount + "\t");
                }
            }
        }

        public void Modify()
        {
           
        }

        public void Delete()
        {
            Console.Write("Enter the Id you want to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManageAccount manageAccount = new ManageAccount();
            foreach(ManageAccount item in accountsCollection)
            {
                if(item.Id == id)
                {
                    manageAccount = item;
                    break;
                }
            }
            accountsCollection.Remove(manageAccount);
        }

        public void Sort()
        {
            accountsCollection.Sort();
        }

        public void Normalize(ManageAccount item)
        {
            item.Description.Replace(" ", "").ToLower();

        }
    }
}
