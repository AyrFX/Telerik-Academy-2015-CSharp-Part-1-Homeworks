/*
 * Problem 3. Divide by 7 and 5
 * Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 * Examples:
 * n 	Divided by 7 and 5?
 * 3 	false
 * 0 	true
 * 5 	false
 * 7 	false
 * 35 	true
 * 140 	true
 */

using System;

class DivideBy7And5
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
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("Въведеното число се дели на 5 и на 7 без остатък.");
        }
        else Console.WriteLine("Въведеното число не се дели на 5 и на 7 без остатък.");
    }
}