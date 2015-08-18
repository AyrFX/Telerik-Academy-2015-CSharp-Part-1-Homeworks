/*
 * Problem 9. Trapezoids
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 * Examples:
 * a 	    b 	    h 	    area
 * 5 	    7 	    12 	    72
 * 2 	    1 	    33 	    49.5
 * 8.5 	    4.3     2.7     17.28
 * 100 	    200     300     45000
 * 0.222    0.333 	0.555 	0.1540125
 */

using System;

class Trapezoids
{
    static void Main()
    {
        double aSide, bSide, height, area;
        string aStr, bStr, hStr;
        Console.Write("Моля, въведете дължината на страната a на трапеца: ");
        aStr = Console.ReadLine();
        Console.Write("Моля, въведете дължината на страната b на трапеца: ");
        bStr = Console.ReadLine();
        Console.Write("Моля, въведете височината на трапеца: ");
        hStr = Console.ReadLine();
        if ((!double.TryParse(aStr, out aSide)) || (!double.TryParse(bStr, out bSide)) || (!double.TryParse(hStr, out height)))
        {
            Console.WriteLine("Не е въведено валидно число за някой от размерите!");
            return;
        }
        area = ((aSide + bSide) * height) / 2;
        Console.WriteLine("Трапец със страни a={0} и b={1} и височина h={2} има лице {3}.", aSide, bSide, height, area);
    }
}