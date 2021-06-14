using System;

namespace Exercise1
{
    class Program
    {
        public static void Calculate(Shape1 S)
        {

            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());

        }

        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            rectangle.AddRectange();
            Calculate(rectangle);

            circle.AddCircle();
            Calculate(circle);

        }
    }
}
