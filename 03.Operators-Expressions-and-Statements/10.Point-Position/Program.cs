/*
 * Problem 10. Point Inside a Circle & Outside of a Rectangle
 * Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle
 * R(top=1, left=-1, width=6, height=2).
 * Examples:
 * x 	y 	    inside K & outside of R
 * 1 	2 	    yes
 * 2.5 	2 	    no
 * 0 	1 	    no
 * 2.5 	1 	    no
 * 2 	0 	    no
 * 4 	0 	    no
 * 2.5 	1.5     no
 * 2 	1.5     yes
 * 1 	2.5     yes
 * -100	-100 	no
 */

using System;

class PointPosition
{
    static void Main()
    {
        double pointX, pointY;
        string xStr, yStr;
        bool insideCircle, outsideRect;
        Console.Write("Моля, въведете x-координатата на точката: ");
        xStr = Console.ReadLine();
        Console.Write("Моля, въведете y-координатата на точката: ");
        yStr = Console.ReadLine();
        if ((!double.TryParse(xStr, out pointX)) || (!double.TryParse(yStr, out pointY)))
        {
            Console.WriteLine("Не е въведено валидно число за някоя от координатите!");
            return;
        }
        if ((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= (1.5 * 1.5))
        {
            insideCircle = true;
        }
        else
        {
            insideCircle = false;
        }
        if ((pointX < -1) || (pointX > 5) || (pointY < -1) || (pointY > 1))
        {
            outsideRect = true;
        }
        else
        {
            outsideRect = false;
        }
        if (insideCircle && outsideRect)
        {
            Console.WriteLine("Точката със зададените координати е вътрешна за окръжността и външна за правоъгълмика.");
        }
        else
        {
            Console.WriteLine("Точката със зададените координати не е вътрешна за окръжността и/или не е външна за правоъгълмика.");
        }
    }
}