/*
 * Problem 5. The Biggest of 3 Numbers
 * Write a program that finds the biggest of three numbers.
 * 
 * Examples:
 * a 	b 	    c 	    biggest
 * 5 	2 	    2 	    5
 * -2 	-2 	    1 	    1
 * -2 	4 	    3 	    4
 * 0 	-2.5 	5 	    5
 * -0.1 -0.5 	-1.1 	-0.1
 */

using System;

class BiggestOfThreeNumbers
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
        if ((aNumber >= bNumber) && (aNumber >= cNumber))
        {
            Console.WriteLine("biggest = {0}", aNumber);
        }
        else if ((aNumber < bNumber) && (aNumber >= cNumber))
        {
            Console.WriteLine("biggest = {0}", bNumber);
        }
        else if ((aNumber >= bNumber) && (aNumber < cNumber))
        {
            Console.WriteLine("biggest = {0}", cNumber);
        }
        else
        {
            if (bNumber >= cNumber)
            {
                Console.WriteLine("biggest = {0}", bNumber);
            }
            else
            {
                Console.WriteLine("biggest = {0}", cNumber);
            }
        }
    }
}