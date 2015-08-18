/*
 * Problem 14. Modify a Bit at Given Position
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p.
 * Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary
 * representation of n while preserving all other bits in n.
 * Examples:
 * n 	    binary representation of n 	p 	v 	binary result 	    result
 * 5 	    00000000 00000101        	2 	0 	00000000 00000001 	1
 * 0 	    00000000 00000000 	        9 	1 	00000010 00000000 	512
 * 15 	    00000000 00001111 	        1 	1 	00000000 00001111 	15
 * 5343 	00010100 11011111 	        7 	0 	00010100 01011111 	5215
 * 62241 	11110011 00100001 	        11 	0 	11110011 00100001 	62241
 */

using System;

class ModifyBit
{
    static void Main()
    {
        int number, bit, value;
        Console.Write("Моля, въведете цяло положително число: ");
        string numberStr = Console.ReadLine();
        Console.Write("Моля, въведете номер на бит за промяна: ");
        string bitStr = Console.ReadLine();
        Console.Write("Моля, въведете стойност (0 или 1): ");
        string valueStr = Console.ReadLine();
        if ((!int.TryParse(numberStr, out number)) || (!int.TryParse(bitStr, out bit)) || (!int.TryParse(valueStr, out value)))
        {
            Console.WriteLine("Не е въведено валидно число, номер на бит или стойност!");
            return;
        }
        if ((number < 0) || (bit < 0) || (value < 0))
        {
            Console.WriteLine("Въведеното число и/или номер на бит не е положително число!");
        }
        if ((value != 0) && (value != 1))
        {
            Console.WriteLine("Задаваната стойност може да бъде само 1 или 0!");
        }
        int result;
        if (value == 0)
        {
            int mask = ~(1 << bit);
            result = number & mask;
        }
        else
        {
            int mask = 1 << bit;
            result = number | mask;      
        }
        Console.WriteLine("Числото {0} се представя в двуичен вид като {1}.", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("При задаване на {0}-я бит се получава числото {1}, което е равно на {2}", bit, Convert.ToString(result, 2).PadLeft(16, '0'), result);
    }
}