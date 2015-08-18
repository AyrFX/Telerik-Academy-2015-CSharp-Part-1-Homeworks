//Create a console application that prints the current date and time. Find out how in Internet.
using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime CurrentDT = DateTime.Now;
        Console.WriteLine("Днес е " + CurrentDT.ToString("dd.MM.yyyy") + " г.");
        Console.WriteLine("В момента е " + CurrentDT.ToString("HH:mm:ss") + " ч.");
    }
}
