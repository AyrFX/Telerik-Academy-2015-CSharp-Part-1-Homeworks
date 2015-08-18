/*
 * Problem 1. Sum of 3 Numbers
 * Write a program that reads 3 real numbers from the console and prints their sum.
 * Examples:
 * a 	b 	c   	sum
 * 3 	4 	11 	    18
 * -2 	0 	3 	    1
 * 5.5 	4.5	20.1 	30.1
 */
using System;

class SumOf3Numbers
{
    static void Main()
    {
        double firstNumber, secondNumber, thirdNumber;
        Console.Write("a= ");
        double.TryParse(Console.ReadLine(), out firstNumber);
        Console.Write("b= ");
        double.TryParse(Console.ReadLine(), out secondNumber);
        Console.Write("c= ");
        double.TryParse(Console.ReadLine(), out thirdNumber);
        Console.WriteLine("a+b+c= " + (firstNumber+secondNumber+thirdNumber));
    }
}
