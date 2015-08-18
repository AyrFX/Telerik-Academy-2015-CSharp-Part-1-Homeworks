/*
 * Problem 15. Hexadecimal to Decimal Number
 * Using loops write a program that converts a hexadecimal integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.
 * 
 * Examples:
 * hexadecimal 	decimal
 * FE 	        254
 * 1AE3 	    6883
 * 4ED528CBB4 	338583669684
 */

using System;
using System.Globalization;

class HexToDec
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string bNumber = Console.ReadLine();
        long dNumber = 0;
        byte digit;
        NumberStyles style = NumberStyles.HexNumber;
        for (int i = bNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            digit = byte.Parse(bNumber[i].ToString(), style);
            dNumber += (long)(digit * Math.Pow(16, j));
        }
        Console.WriteLine(dNumber);
    }
}