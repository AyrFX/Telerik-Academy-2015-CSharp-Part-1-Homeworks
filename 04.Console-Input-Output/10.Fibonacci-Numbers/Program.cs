/*
 * Problem 10. Fibonacci Numbers
 * Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
 * (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 * Note: You may need to learn how to use loops.
 * 
 * Examples:
 * n 	comments
 * 1 	0
 * 3 	0 1 1
 * 10 	0 1 1 2 3 5 8 13 21 34
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number length of the Fibonacci sequence: ");
        int numCounter;
        int.TryParse(Console.ReadLine(), out numCounter);
        int firstNumber = 0, secondNumber = 1, currentNumber;
        string sequence = "";
        for (int cnt = 0; cnt < numCounter; cnt++)
        {
            if (cnt == 0)
            {
                currentNumber = firstNumber;
            }
            else
            {
                currentNumber = firstNumber + secondNumber;
            }
            sequence +=  currentNumber.ToString();
            if (cnt != (numCounter - 1))
            {
                sequence += ", ";
            }
            firstNumber = secondNumber;
            secondNumber = currentNumber;
        }
        Console.WriteLine(new String('=', 40));
        Console.WriteLine("The Fibonacci sequence is: " + sequence);
    }
}