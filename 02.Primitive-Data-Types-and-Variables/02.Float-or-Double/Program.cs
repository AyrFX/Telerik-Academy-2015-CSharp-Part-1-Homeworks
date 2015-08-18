/*
 * Problem 2. Float or Double?
 * Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023,
 * 12.345, 8923.1234857, 3456.091?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstDoubleNumber = 34.567839023; //double can store numbers with 15-16 digits
        float firstFloatNumber = 12.345f; //float can store numbers with 7 digits
        double secondDoubleNumber = 8923.1234857;
        float secondFloatNumber = 3456.091f;

        Console.WriteLine("Първото число с плаваща запетая е " + firstDoubleNumber);
        Console.WriteLine("Второто число с плаваща запетая е " + firstFloatNumber);
        Console.WriteLine("Третото число с плаваща запетая е " + secondDoubleNumber);
        Console.WriteLine("Четвъртото число с плаваща запетая е " + secondFloatNumber);
        //source: http://msdn.microsoft.com/en-us/library/9ahet949.aspx
    }
}