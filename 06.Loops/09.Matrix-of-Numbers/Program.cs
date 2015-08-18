/*
 * Problem 9. Matrix of Numbers
 * Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below.
 * Use two nested loops.
 * 
 * Examples:
 * n = 2   matrix      n = 3   matrix      n = 4   matrix
 *     1 2                 1 2 3               1 2 3 4
 *     2 3                 2 3 4               2 3 4 5
 *                         3 4 5               3 4 5 6
 *                                             4 5 6 7
 */

using System;
using System.Text;

class NumbersMatrix
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Please enter n (1 ≤ n ≤ 20): ");
        byte n = byte.Parse(Console.ReadLine());
        string outputLine;
        for (int i = 1; i <= n; i++)
        {
            outputLine = "";
            for (int j = i; j < n + i; j++)
            {
                outputLine += String.Format("{0, 2}",j);
                /*if (j != n + i - 1)
                {
                    outputLine += " ";
                }*/
            }
            Console.WriteLine(outputLine);
        }
    }
}