//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Моля, въведете рожденния си ден: ");
        string DTText  = Console.ReadLine();
        DateTime BDay;
        if (!DateTime.TryParse(DTText, out BDay))
        {
            Console.WriteLine("Не е въведена валидна рожденна дата!");
            return;
        }
        DateTime Today = DateTime.Today;
        if (BDay.CompareTo(Today) >= 0)
        {
            Console.WriteLine("Въведената дата все още не е настъпила!");
            return;
        }
        int Age = Today.Year - BDay.Year - 1;
        if (Today.Month > BDay.Month) Age++;
        else
        {
            if ((Today.Month == BDay.Month) && (Today.Day >= BDay.Day)) Age++;
        }
        Console.WriteLine("Сега Вие сте на {0} години.", Age);
        Console.WriteLine("След 10 години Вие ще бъдете на {0} години.", Age + 10);
    }
}
