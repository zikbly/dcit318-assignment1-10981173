using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the sides of the triangle:");
        Console.Write("Side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("This is an Equilateral triangle.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("This is an Isosceles triangle.");
        }
        else
        {
            Console.WriteLine("This is a Scalene triangle.");
        }
    }
}
