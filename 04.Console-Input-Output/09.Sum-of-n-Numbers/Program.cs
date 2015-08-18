/*
 * Problem 9. Sum of n Numbers
 * Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
 * Note: You may need to use a for-loop.
 * 
 * Examples:
 * numbers 	sum
 * 3 	    90
 * 20 	
 * 60 	
 * 10 	
 * 5 	    6.5
 * 2 	
 * -1 	
 * -0.5 	
 * 4 	
 * 2 	
 * 1 	    1
 * 1 	
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number for sum: ");
        int numCounter;
        int.TryParse(Console.ReadLine(), out numCounter);
        double inputNumber = 0, sum = 0;
        for (int cnt = 1; cnt <= numCounter; cnt++)
        {
            Console.Write("Enter number {0}: ", cnt);
            double.TryParse(Console.ReadLine(), out inputNumber);
            sum += inputNumber;
        }
        Console.WriteLine(new String('=', 40));
        Console.WriteLine("The sum of numbers is: " + sum);
    }
}