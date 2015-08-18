/*
 * Problem 2. Gravitation on the Moon
 * The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 * Examples:
 * weight 	weight on the Moon
 * 86       	14.62
 * 74.6 	    12.682
 * 53.7     	9.129
 */

using System;

class MoonGravitation
{
    static void Main()
    {
        int weight;
        Console.Write("Моля, въведете тегло (цяло число в кг.): ");
        string inputStr = Console.ReadLine();
        if (!int.TryParse(inputStr, out weight))
        {
            Console.WriteLine("Не е въведено валидно тегло!");
            return;
        }
        double moonWeight = (weight / 100.0) * 17;
        Console.WriteLine("{0} кг. на земята се равняват на {1} кг. на луната.", weight, moonWeight);
    }
}