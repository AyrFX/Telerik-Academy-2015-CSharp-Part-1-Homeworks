/*
 * Problem 3. Circle Perimeter and Area
 * Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 * 
 * Examples:
 * r 	perimeter 	area
 * 2 	12.57 	12.57
 * 3.5 	21.99 	38.48
 */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r=");
        double r;
        double.TryParse(Console.ReadLine(), out r);
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine(new String('=', 40));
        Console.WriteLine("P={0:0.00}", perimeter);
        Console.WriteLine("S={0:0.00}", area);
    }
}