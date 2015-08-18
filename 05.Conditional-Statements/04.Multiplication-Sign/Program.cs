/*
 * Problem 4. Multiplication Sign
 * Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 * Use a sequence of if operators.
 * 
 * Examples:
 * a 	b 	    c 	    result
 * 5 	2 	    2 	    +
 * -2 	-2 	    1 	    +
 * -2 	4 	    3 	    -
 * 0 	-2.5 	4 	    0
 * -1 	-0.5 	-5.1 	-
 */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double aNumber;
        double.TryParse(Console.ReadLine(), out aNumber);
        Console.Write("Please enter number b: ");
        double bNumber;
        double.TryParse(Console.ReadLine(), out bNumber);
        Console.Write("Please enter number c: ");
        double cNumber;
        double.TryParse(Console.ReadLine(), out cNumber);
        char sign;
        if ((aNumber == 0) || (bNumber == 0) || (cNumber == 0))
        {
            Console.WriteLine("Result = 0");
        }
        else
        {
            if (aNumber > 0)
            {
                sign = '+';
            }
            else
            {
                sign = '-'; ;
            }
            if (((bNumber > 0) && (sign == '+')) || ((bNumber < 0) && (sign == '-')))
            {
                sign = '+';
            }
            else
            {
                sign = '-';
            }
            if (((cNumber > 0) && (sign == '+')) || ((cNumber < 0) && (sign == '-')))
            {
                sign = '+';
            }
            else
            {
                sign = '-';
            }
            Console.WriteLine("Result = " + sign);
        }
    }
}