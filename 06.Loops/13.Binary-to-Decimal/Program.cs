/*
 * Problem 13. Binary to Decimal Number
 * Using loops write a program that converts a binary integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.
 * 
 * Examples:
 * binary 	                    decimal
 * 0 	                        0
 * 11 	                        3
 * 1010101010101011 	        43691
 * 1110000110000101100101000000 236476736
 */

using System;

class BinaylToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string bNumber = Console.ReadLine();
        long dNumber = 0;
        byte digit;
        for (int i = bNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            digit = byte.Parse(bNumber[i].ToString());
            dNumber += (long)(digit * Math.Pow(2, j));
        }
        Console.WriteLine(dNumber);
    }
}