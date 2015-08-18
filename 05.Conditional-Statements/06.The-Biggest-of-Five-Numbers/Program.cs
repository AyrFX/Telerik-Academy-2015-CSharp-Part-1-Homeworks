/*
 * Problem 6. The Biggest of Five Numbers
 * Write a program that finds the biggest of five numbers by using only five if statements.
 * 
 * Examples:
 * a 	b 	    c 	    d 	e 	    biggest
 * 5 	2 	    2 	    4 	1 	    5
 * -2 	-22 	1 	    0 	0 	    1
 * -2 	4 	    3 	    2 	0 	    4
 * 0 	-2.5 	0 	    5 	5 	    5
 * -3 	-0.5 	-1.1 	-2 	-0.1 	-0.1
 */

using System;

class BiggestOfFiveNumbers
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
        Console.Write("Please enter number d: ");
        double dNumber;
        double.TryParse(Console.ReadLine(), out dNumber);
        Console.Write("Please enter number e: ");
        double eNumber;
        double.TryParse(Console.ReadLine(), out eNumber);
        if ((aNumber >= bNumber) && (aNumber >= cNumber) && (aNumber >= dNumber) && (aNumber >= eNumber))
        {
            Console.WriteLine("biggest = {0}", aNumber);
            return;
        }
        if ((bNumber >= aNumber) && (bNumber >= cNumber) && (bNumber >= dNumber) && (bNumber >= eNumber))
        {
            Console.WriteLine("biggest = {0}", bNumber);
            return;
        }
        if ((cNumber >= aNumber) && (cNumber >= bNumber) && (cNumber >= dNumber) && (cNumber >= eNumber))
        {
            Console.WriteLine("biggest = {0}", cNumber);
            return;
        }
        if ((dNumber >= aNumber) && (dNumber >= bNumber) && (dNumber >= cNumber) && (dNumber >= eNumber))
        {
            Console.WriteLine("biggest = {0}", dNumber);
            return;
        }
        if ((eNumber >= aNumber) && (eNumber >= bNumber) && (eNumber >= cNumber) && (eNumber >= dNumber))
        {
            Console.WriteLine("biggest = {0}", eNumber);
            return;
        }
    }
}