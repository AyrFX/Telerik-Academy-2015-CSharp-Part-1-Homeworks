/*
 * Problem 12.* Randomize the Numbers 1…N
 * Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 * 
 * Examples:
 * n 	randomized numbers 1…n
 * 3 	2 1 3
 * 10 	3 4 8 2 6 7 9 1 10 5
 * 
 * Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
 * You might need to use arrays.
 */

using System;

class NumbersRandomize
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            intArray[i] = i+1;
        }
        Random position = new Random();
        for (int i = 0; i < n; i++)
        {
            int newPosition = position.Next(n);
            int temp;
            temp = intArray[i];
            intArray[i] = intArray[newPosition];
            intArray[newPosition] = temp;
        }
        string outputString = "";
        for (int i = 1; i <= n; i++)
        {
            outputString += intArray[i-1];
            if (i != n)
            {
                outputString += " ";
            }
        }
        Console.WriteLine(outputString);
    }
}