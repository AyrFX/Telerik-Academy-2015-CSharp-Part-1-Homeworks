/*
 * Problem 9. Exchange Variable Values
 * Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some
 * programming logic.
 * Print the variable values before and after the exchange.
 */

using System;

class ExchangeValues
{
    static void Main()
    {
        int firstInt, secInt;
        firstInt = 5;
        secInt = 10;
        Console.WriteLine("Първа променлива = {0}\nВтора променлива = {1}", firstInt, secInt);
        firstInt = firstInt + secInt;
        secInt = firstInt - secInt;
        firstInt = firstInt - secInt;
        Console.WriteLine("=====================");
        Console.WriteLine("Първа променлива = {0}\nВтора променлива = {1}", firstInt, secInt);
    }
}