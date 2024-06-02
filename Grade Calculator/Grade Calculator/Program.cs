
using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 70 && grade <= 89.99)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 60 && grade <= 69.99)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 50 && grade <= 59.99)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}

