/*
 * Problem 16. Decimal to Hexadecimal Number
 * Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
 * 
 * Examples:
 * decimal 	        hexadecimal
 * 254 	            FE
 * 6883 	        1AE3
 * 338583669684 	4ED528CBB4
 */

using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Please enter integer: ");
        long intNumber = long.Parse(Console.ReadLine());
        string result = "";
        do
        {
            switch (intNumber % 16)
            {
                case 10:
                    result = "A" + result;
                    break;
                case 11:
                    result = "B" + result;
                    break;
                case 12:
                    result = "C" + result;
                    break;
                case 13:
                    result = "D" + result;
                    break;
                case 14:
                    result = "E" + result;
                    break;
                case 15:
                    result = "F" + result;
                    break;
                default:
                    result = (intNumber % 16) + result;
                    break;
            }
            intNumber = intNumber / 16;
        }
        while (intNumber >= 1);
        Console.WriteLine(result);
    }
}