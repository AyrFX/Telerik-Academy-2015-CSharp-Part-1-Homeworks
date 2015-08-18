/*
 * Problem 7. Point in a Circle
 * Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 * Examples:
 * x 	y 	    inside
 * 0 	1 	    true
 * -2 	0 	    true
 * -1 	2 	    false
 * 1.5 	-1  	true
 * -1.5	-1.5 	false
 * 100 	-30 	false
 * 0 	0 	    true
 * 0.2 	-0.8 	true
 * 0.9 	-1.93 	false
 * 1 	1.655 	true
 */

using System;

class PointInACircle
{
    static void Main()
    {
        double pointX, pointY;
        string xStr, yStr;
        Console.Write("Моля, въведете x-координатата на точката: ");
        xStr = Console.ReadLine();
        Console.Write("Моля, въведете y-координатата на точката: ");
        yStr = Console.ReadLine();
        if ((!double.TryParse(xStr, out pointX)) || (!double.TryParse(yStr, out pointY)))
        {
            Console.WriteLine("Не е въведено валидно число за някоя от координатите!");
            return;
        }
        if (pointX * pointX + pointY * pointY <= 2 * 2)
        {
            Console.WriteLine("Точката със зададените координати е вътрешна за окръжността.");
        }
        else
        {
            Console.WriteLine("Точката със зададените координати е външна за окръжността.");
        }
    }
}