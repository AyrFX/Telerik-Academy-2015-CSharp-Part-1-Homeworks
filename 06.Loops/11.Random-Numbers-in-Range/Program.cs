/*
 * Problem 11. Random Numbers in Given Range
 * Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 * 
 * Examples:
 * n 	min 	max 	random numbers
 * 5 	0 	    1 	    1 0 0 1 1
 * 10 	10 	    15 	    12 14 12 15 10 12 14 13 13 11
 * 
 * Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
 */

using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please enter max: ");
        int max = int.Parse(Console.ReadLine());
        Random rNumber = new Random();
        string outputString = "";
        for (int i = 1; i <= n; i++)
        {
            outputString += rNumber.Next(min, max + 1);
            if (i != n)
            {
                outputString += " ";
            }
        }
        Console.WriteLine(outputString);
    }
}