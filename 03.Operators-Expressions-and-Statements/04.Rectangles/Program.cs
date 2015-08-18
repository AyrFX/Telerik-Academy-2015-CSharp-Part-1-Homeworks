/*
 * Problem 4. Rectangles
 * Write an expression that calculates rectangle’s perimeter and area by given width and height.
 * Examples:
 * width 	height 	perimeter 	area
 * 3       	4    	14       	12
 * 2.5   	3   	11       	7.5
 * 5 	    5   	20      	25
 */

using System;

class Rectangles
{
    static void Main()
    {
        double width, height, perimeter, area;
        string widthStr, heightStr;
        Console.Write("Моля, въведете широчината на правоъгълника: ");
        widthStr = Console.ReadLine();
        Console.Write("Моля, въведете височината на правоъгълника: ");
        heightStr = Console.ReadLine();
        if ((!double.TryParse(widthStr, out width)) || (!double.TryParse(heightStr, out height)))
        {
            Console.WriteLine("Не е въведено валидно число за някой от размерите!");
            return;
        }
        perimeter = 2 * (width + height);
        area = width * height;
        Console.WriteLine("Правоъгълник с широчина {0} и височина {1} има периметър {2} и лице {3}.", width, height, perimeter, area);
    }
}