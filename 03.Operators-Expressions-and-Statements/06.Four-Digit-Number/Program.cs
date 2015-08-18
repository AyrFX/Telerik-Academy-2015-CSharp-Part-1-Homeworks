/*
 * Problem 6. Four-Digit Number
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 * Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
 * Prints on the console the number in reversed order: dcba (in our example 1102).
 * Puts the last digit in the first position: dabc (in our example 1201).
 * Exchanges the second and the third digits: acbd (in our example 2101).
 * 
 * The number has always exactly 4 digits and cannot start with 0.
 * 
 * Examples:
 * n    	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
 * 2011     4 	            1102     	1201                 	2101
 * 3333 	12          	3333 	    3333                 	3333
 * 9876 	30          	6789    	6987                 	9786
 */

using System;

class FourDigitNumber
{
    static void Main()
    {
        int number, a, b, c, d;
        string numberStr;
        Console.Write("Моля, въведете цяло четирицифрено число (abcd): ");
        numberStr = Console.ReadLine();
        if (!int.TryParse(numberStr, out number))
        {
            Console.WriteLine("Не е въведено валидно цяло число!");
            return;
        }
        if ((number < 999) || (number > 9999))
        {
            Console.WriteLine("Въведеното число не е четирицифрено!");
            return;
        }
        d = number % 10;
        number /= 10;
        c = number % 10;
        number /= 10;
        b = number % 10;
        a = number / 10;
        Console.WriteLine("Сумата на цифрите на въведеното число е " + (a+b+c+d));
        Console.WriteLine("Числото, чиито цифри са в обратен ред (dcba) на въведеното е " + d+c+b+a);
        Console.WriteLine("Числото, с преместена последна цифра на първа позиция (dabc) е " + d + a + b + c);
        Console.WriteLine("Числото, с разменени втора и трета цифра (acbd) е " + a + c + b + d);
    }
}