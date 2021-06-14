using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle : Shape1
    {
        public float L { get; set; }
        public float B { get; set; }

        public void AddRectange()
        {
            Console.Write("Enter length： ");
            L = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter breadth： ");
            B = Convert.ToInt32(Console.ReadLine());
        }


        public override float Area()
        {
            float area = L * B;
            return area;
        }

        public override float Circumference()
        {
            float circumference = 2 * (L + B);
            return circumference;
        }
    }

}

