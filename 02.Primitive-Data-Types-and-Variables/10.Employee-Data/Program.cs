/*
 * Problem 10. Employee Data
 * A marketing company wants to keep record of its employees. Each record would have the following characteristics:
 * First name
 * Last name
 * Age (0...100)
 * Gender (m or f)
 * Personal ID number (e.g. 8306112507)
 * Unique employee number (27560000…27569999)
 * Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
 * Use descriptive names. Print the data at the console.
 */

using System;

class EmplData
{
    static void Main()
    {
        string firstName = "Димитър";
        string lastName = "Георгиев";
        byte age = 32;
        bool isMale = true;
        long personalID =  8305180045; //ulong is also appropriate and uses the same amount of memory
        int uniqueEmplNumber = 27560053; //uint is also appropriate and uses the same amount of memory
        Console.WriteLine("Служител: " + firstName + ' ' + lastName);
        if (isMale) Console.WriteLine("Пол: мъжки");
        else Console.WriteLine("Пол: женски");
        Console.WriteLine("Възраст: " + age + " г.");
        Console.WriteLine("ЕГН: " + personalID);
        Console.WriteLine("Служебен номер: " + uniqueEmplNumber);
    }
}