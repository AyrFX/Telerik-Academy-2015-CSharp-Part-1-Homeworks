/*
 * Problem 8. Catalan Numbers
 * In combinatorics, the Catalan numbers are calculated by the following formula: CATALAN FORMULA.
 * Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
 * 
 * Examples:
 * n 	Catalan(n)
 * 0 	1
 * 5 	42
 * 10 	16796
 * 15 	9694845
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1, factorialIncN = 1, factorial2N = 1;
        for (int i = 1; i <= n * 2; i++)
        {
            factorial2N *= i;
            if (i <= n + 1)
            {
                factorialIncN *= i;
            }
            if (i <= n)
            {
                factorialN *= i;
            }
        }
        Console.WriteLine("The {0}-th Catalan number is {1}", n, factorial2N / (factorialIncN * factorialN));
    }
}