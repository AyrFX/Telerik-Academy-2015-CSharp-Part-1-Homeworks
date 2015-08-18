/*
 * Problem 12. Extract Bit from Integer
 * Write an expression that extracts from given integer n the value of given bit at index p.
 * Examples:
 * n 	    binary representation 	p 	bit @ p
 * 5 	    00000000 00000101 	    2 	1
 * 0 	    00000000 00000000 	    9 	0
 * 15 	    00000000 00001111 	    1 	1
 * 5343 	00010100 11011111    	7 	1
 * 62241 	11110011 00100001 	    11 	0
 */

using System;

class ExtractGivenBit
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
        Console.WriteLine("{0}-я бит на въведеното число е {1}", bitNumber, bit);
    }
}