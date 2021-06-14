using System;
using System.Collections.Generic;

namespace Exercise8
{
    abstract class A
    {
        int x;
        public abstract void f(int n);
        public virtual void g(int n)
        {
            x = n;
        }

        public string ToString()
        {
            return x.ToString();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
