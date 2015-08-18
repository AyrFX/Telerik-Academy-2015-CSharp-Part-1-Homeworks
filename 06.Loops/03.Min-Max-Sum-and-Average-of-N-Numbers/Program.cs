/*
 * Problem 3. Min, Max, Sum and Average of N Numbers
 * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum
 * and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
 * The output is like in the examples below.
 * 
 * Example 1:
 * input 	output
 * 3
 * 2
 * 5
 * 1 	    min = 1
 *          max = 5
 *          sum = 8
 *          avg = 2.67
 *          
 * Example 2:
 * input 	output
 * 2
 * -1
 * 4 	    min = -1
 *          max = 4
 *          sum = 3
 *          avg = 1.50
 */

using System;

class MinMaxSumAvg
{
    static void Main()
    {
        Console.Write("Please enter the number for calculate: ");
        int n = Int32.Parse(Console.ReadLine());
        int min = Int32.MaxValue, max = Int32.MinValue, sum = 0, cnt;
        for (int i = n; i >= 1; i--)
        {
            int number = int.Parse(Console.ReadLine());
            if (min > number)
            {
                min = number;
            }
            if (max < number)
            {
                max = number;
            }
            sum += number;
        }
        string outputString = String.Format("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, (double)sum / n);
        Console.WriteLine(outputString);
    }
}