/*
 * Problem 13.* Comparing Floats
 * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
 */
using System;

class FloatCompare
{
    static void Main()
    {
        double a = 5.3;
        double b = 6.01;
        double eps = 0.000001;
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (Math.Abs(a - b) > eps) Console.WriteLine("a и b НЕ СА равни (с точност " + eps + ")");
        else Console.WriteLine("a и b СА равни (с точност " + eps + ")");
    }
}