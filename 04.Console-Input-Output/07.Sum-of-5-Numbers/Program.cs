/*
 * Problem 7. Sum of 5 Numbers
 * Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 * 
 * Examples:
 * numbers 	            sum
 * 1 2 3 4 5 	        15
 * 10 10 10 10 10 	    50
 * 1.5 3.14 8.2 -1 0 	11.84
 */

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Please enter 5 numbers separated by a spase: ");
        string [] inputNumbers = Console.ReadLine().Split(' ');
        double sum = 0;
        double singleNumber;
        for (int i = 0; i < 5; i++)
        {
            double.TryParse(inputNumbers[i], out singleNumber);
            sum = sum + singleNumber;
        }
        Console.WriteLine("sum= " + sum);
    }
}