/*
 * Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater
 * than the second one. As a result print the values a and b, separated by a space.
 * 
 * Examples:
 * a 	b 	result
 * 5 	2 	2 5
 * 3 	4 	3 4
 * 5.5 	4.5 	4.5 5.5
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please, enter a: ");
        double firstNumber;
        double.TryParse(Console.ReadLine(), out firstNumber);
        Console.Write("Please, enter b: ");
        double secondNumber;
        double.TryParse(Console.ReadLine(), out secondNumber);
        if (firstNumber > secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
        }
        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
    }
}