/*
 * Problem 7. Sort 3 Numbers with Nested Ifs
 * Write a program that enters 3 real numbers and prints them sorted in descending order.
 * Use nested if statements.
 * 
 * Note: Don’t use arrays and the built-in sorting functionality.
 * 
 * Examples:
 * a 	b 	    c 	    result
 * 5 	1 	    2 	    5 2 1
 * -2 	-2 	    1 	    1 -2 -2
 * -2 	4 	    3 	    4 3 -2
 * 0 	-2.5 	5 	    5 0 -2.5
 * -1.1 -0.5    -0.1 	-0.1 -0.5 -1.1
 * 10 	20 	    30 	    30 20 10
 * 1 	1 	    1 	    1 1 1
 */

using System;

class SortThreeNumbersWithNestedIfs
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
        double temp;
        if ((aNumber >= bNumber) && (aNumber >= cNumber))
        {
            if (bNumber < cNumber) //a,c,b --> a,b,c
            {
                temp = bNumber;
                bNumber = cNumber;
                cNumber = temp;
            }
        }
        else if ((aNumber < bNumber) && (aNumber >= cNumber)) //b,a,c --> a,b,c
        {
            temp = aNumber;
            aNumber = bNumber;
            bNumber = temp;
        }
        else if ((aNumber >= bNumber) && (aNumber < cNumber)) //c,a,b --> a,c,b --> a,b,c
        {
            temp = aNumber;
            aNumber = cNumber;
            cNumber = temp;
            temp = cNumber;
            cNumber = bNumber;
            bNumber = temp;
        }
        else
        {
            if (bNumber >= cNumber) //b,c,a --> b,a,c --> a,b,c
            {
                temp = aNumber;
                aNumber = cNumber;
                cNumber = temp;
                temp = aNumber;
                aNumber = bNumber;
                bNumber = temp;
            }
            else //c,b,a --> a,b,c
            {
                temp = aNumber;
                aNumber = cNumber;
                cNumber = temp;
            }
        }
        Console.WriteLine("{0} {1} {2}", aNumber, bNumber, cNumber);
    }
}