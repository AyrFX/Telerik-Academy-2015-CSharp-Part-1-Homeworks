/*
 * Problem 8. Prime Number Check
 * Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder
 * only to itself and 1).
 * Note: You should check if the number is positive
 * Examples:
 * n 	Prime?
 * 1 	false
 * 2 	true
 * 3 	true
 * 4 	false
 * 9 	false
 * 97 	true
 * 51 	false
 * -3 	false
 * 0 	false
 */

using System;

class PrimesCheck
{
    static void Main()
    {
        int number, counter;
        Console.Write("Моля, въведете цяло положително число от 0 до 100: ");
        string inputStr = Console.ReadLine();
        if (!int.TryParse(inputStr, out number))
        {
            Console.WriteLine("Не е въведено валидно число!");
            return;
        }
        if (number > 100)
        {
            Console.WriteLine("Въведеното число е по-голямо от 100!");
            return;
        }
        if (number <= 1)
        {
            Console.WriteLine("Въведеното число НЕ Е просто.");
            return;
        }
        for (counter = 1; counter < number; counter++)
        {
            if (number % counter == 0)
            {
                Console.WriteLine("Въведеното число НЕ Е просто.");
                return;
            }
        }
        Console.WriteLine("Въведеното число Е просто.");
    }
}