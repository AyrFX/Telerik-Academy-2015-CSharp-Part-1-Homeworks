/*
 * Problem 1. Numbers from 1 to N
 * Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line,
 * separated by a space.
 * 
 * Examples:
 * n 	output
 * 3 	1 2 3
 * 5 	1 2 3 4 5
 */

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter n (n>0): ");
        int number = int.Parse(Console.ReadLine());
        string outputString = "";
        for (int i = 1; i <= number; i++)
        {
            outputString += " " + i;
        }
        Console.WriteLine(outputString);
    }
}