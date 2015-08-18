/*
 * Problem 6. Quadratic Equation
 * Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 * 
 * Examples:
 * a 	b 	c 	roots
 * 2 	5 	-3 	x1=-3; x2=0.5
 * -1 	3 	0 	x1=3; x2=0
 * -0.5 4 	-8 	x1=x2=4
 * 5 	2 	8 	no real roots
 */

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a= ");
        double aParam;
        double.TryParse(Console.ReadLine(), out aParam);
        Console.Write("b= ");
        double bParam;
        double.TryParse(Console.ReadLine(), out bParam);
        Console.Write("c= ");
        double cParam;
        double.TryParse(Console.ReadLine(), out cParam);
        Console.WriteLine(new String('=', 40));
        double d = Math.Pow(bParam, 2) - (4 * aParam * cParam);
        if (d < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if (d == 0)
        {
            double x = (-1 * bParam) / (2 * aParam);
            Console.WriteLine("x1 = x2 = " + x);
        }
        else
        {
            double x1 = ((-1 * bParam) - Math.Sqrt(d)) / (2 * aParam);
            double x2 = ((-1 * bParam) + Math.Sqrt(d)) / (2 * aParam);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
    }
}