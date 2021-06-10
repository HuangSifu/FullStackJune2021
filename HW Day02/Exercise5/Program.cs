//Author: Bochen Huang
//FullStack June 2021
using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double volume = 0.0;

            Box1.setLength(2.0);
            Box1.setBreadth(3.0);
            Box1.setHeight(4.0);

            Box2.setLength(5.0);
            Box2.setBreadth(6.0);
            Box2.setHeight(7.0);

            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            Box3 = Box1 + Box2;

            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
        }
    }
}
