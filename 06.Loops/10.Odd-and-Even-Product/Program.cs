/*
 * Problem 10. Odd and Even Product
 * You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 * 
 * Examples:
 * numbers 	        result
 * 2 1 1 6 3 	    yes
 * product = 6
 * 3 10 4 6 5 1 	yes
 * product = 60 	
 * 4 3 2 5 2 	    no
 * odd_product = 16 	
 * even_product = 15 	
 */

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please enter numbers, separated by a space: ");
        string[] inputNumbers = Console.ReadLine().Split(' ');
        int oddProduct = 1, evenProduct = 1;
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                evenProduct *= int.Parse(inputNumbers[i]);
            }
            else
                oddProduct *= int.Parse(inputNumbers[i]);
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Products are equal = " + evenProduct);
        }
        else
        {
            Console.WriteLine("Product of even numbers = " + evenProduct);
            Console.WriteLine("Product of odd numbers = " + oddProduct);
        }
    }
}