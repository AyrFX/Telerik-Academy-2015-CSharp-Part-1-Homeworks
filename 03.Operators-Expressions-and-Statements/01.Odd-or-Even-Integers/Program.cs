/* 
 * Problem 1. Odd or Even Integers
 * Write an expression that checks if given integer is odd or even.
 * Examples:
 * n 	Odd?
 * 3 	true
 * 2 	false
 * -2 	false
 * -1 	true
 * 0 	false
 */

using System;

class OddOrEven
{
    static void Main()
    {
        int number;
        Console.Write("Моля, въведете цяло число: ");
        string inputStr = Console.ReadLine();
        if (!int.TryParse(inputStr, out number))
        {
            Console.WriteLine("Не е въведено валидно число!");
            return;
        }
        if (number % 2 == 0)
        {
            Console.WriteLine("Въведеното число е четно.");
        }
        else Console.WriteLine("Въведеното число е нечетно.");
    }
}