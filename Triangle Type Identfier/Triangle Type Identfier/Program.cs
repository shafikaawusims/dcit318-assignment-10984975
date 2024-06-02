
using System;

namespace TriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }
    }
}
