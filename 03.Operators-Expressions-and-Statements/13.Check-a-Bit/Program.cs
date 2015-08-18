/*
 * Problem 13. Check a Bit at Given Position
 * Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer
 * number n, has value of 1.
 * Examples:
 * n 	    binary representation of n 	p 	bit @ p == 1
 * 5 	    00000000 00000101 	        2 	true
 * 0 	    00000000 00000000 	        9 	false
 * 15 	    00000000 00001111 	        1 	true
 * 5343 	00010100 11011111 	        7 	true
 * 62241 	11110011 00100001 	        11 	false
 */

using System;

class CheckABit
{
    static void Main()
    {
        int number, bitNumber;
        Console.Write("Моля, въведете цяло положително число: ");
        string numberStr = Console.ReadLine();
        Console.Write("Моля, въведете номера на търсения бит: ");
        string bitStr = Console.ReadLine();
        if ((!int.TryParse(numberStr, out number)) || (!int.TryParse(bitStr, out bitNumber)))
        {
            Console.WriteLine("Не е въведено валидно число или номер на бит!");
            return;
        }
        if ((number < 0) || (bitNumber < 0))
        {
            Console.WriteLine("Въведеното число и/или номер на бит не е положително число!");
        }
        int mask = 1 << bitNumber;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitNumber;
        Console.WriteLine("Числото {0} се представя в двуичен вид като {1}.", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        if (bit == 1)
        {
            Console.WriteLine("{0}-я бит на въведеното число е 1 ==> {1}", bitNumber, true);
        }
        else
        {
            Console.WriteLine("{0}-я бит на въведеното число е 1 ==> {1}", bitNumber, false);
        }
    }
}