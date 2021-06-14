using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static List<Customer> CreateCustomers()
        {
            return new List<Customer>
                {
                    new Customer(1) { Name = "Maria Anders",     City = "Berlin"    },
                    new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
                    new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
                    new Customer(4) { Name = "Ann Devon",        City = "London"    },
                    new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
                    new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
                    new Customer(7) { Name = "Simon Crowther",   City = "London"    },
                    new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
                };

        }

        public static List<Customer> FindCustomersByCity(
            List<Customer> customers,
            string city)
        {
            return customers.FindAll(c => c.City == city);
        }
        static void Main(string[] args)
        {
            var customers = CreateCustomers();
            var customerDictionary = new Dictionary<Customer, string>();

            foreach (var c in customers)
                customerDictionary.Add(c, c.Name.Split(' ')[1]);

            var matches = customerDictionary.FilterBy(
                (customer, lastName) => lastName.StartsWith("A")); 
            Console.WriteLine("Number of Matches: {0}", matches.Count);

        }
    }
}

