using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    public class Person
    {
        private int age;
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
