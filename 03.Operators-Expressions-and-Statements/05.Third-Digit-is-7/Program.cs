/*
 * Problem 5. Third Digit is 7?
 * Write an expression that checks for given integer if its third digit from right-to-left is 7.
 * Examples:
 * n 	Third digit 7?
 * 5 	    false
 * 701 	    true
 * 9703     true
 * 877 	    false
 * 777877 	false
 * 9999799 	true
 */

using System;

class ThirdDigit
{
    static void Main()
    {
        int number;
        string numberStr;
        Console.Write("Моля, въведете цяло число: ");
        numberStr = Console.ReadLine();
        if (!int.TryParse(numberStr, out number))
        {
            Console.WriteLine("Не е въведено валидно цяло число!");
            return;
        }
        if (number < 100)
        {
            Console.WriteLine("Третата цифра от дясно наляво не е 7.");
            return;
        }
        number /= 100;
        if (number % 10 == 7)
        {
            Console.WriteLine("Третата цифра от дясно наляво е 7.");
        }
        else
        {
            Console.WriteLine("Третата цифра от дясно наляво не е 7.");
        }
    }
}