using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Circle : Shape1
    {
        public float R { get; set; }

        public void AddCircle()
        {
            Console.Write("Enter radius： ");
            R = Convert.ToInt32(Console.ReadLine());
        }

        public override float Area()
        {
            float pi = (float)3.14;
            float area = pi * R * R;
            return area;
        }

        public override float Circumference()
        {
            float pi = (float)3.14;
            float circumference = 2 * pi * R;
            return circumference;

        }

    }
}
