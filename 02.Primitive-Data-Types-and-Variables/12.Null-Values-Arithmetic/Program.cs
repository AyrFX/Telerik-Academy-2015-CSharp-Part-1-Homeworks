/*
 * Problem 12. Null Values Arithmetic
 * Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console.
 * Try to add some number or the null literal to these variables and print the result.
 */

using System;

class NullValues
{
    static void Main()
    {
        int? someInt = null;
        double? someDouble = null;
        Console.WriteLine("someInt = " + someInt);
        Console.WriteLine("someDouble = " + someDouble);
        Console.WriteLine("==========================");
        someInt = someInt + null;
        someDouble = someDouble + null;
        Console.WriteLine("someInt + null = " + someInt);
        Console.WriteLine("someDouble + null = " + someDouble);
        Console.WriteLine("==========================");
        someInt = someInt + 12;
        someDouble = someDouble + 12.4;
        Console.WriteLine("someInt + 12 = " + someInt);
        Console.WriteLine("someDouble + 12.4 = " + someDouble);
        Console.WriteLine("==========================");
    }
}
