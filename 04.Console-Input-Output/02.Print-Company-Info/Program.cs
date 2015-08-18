/*
 * Problem 2. Print Company Information
 * A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age
 * and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 * Example input:
 * program       	    user
 * Company name: 	    Telerik Academy
 * Company address: 	31 Al. Malinov, Sofia
 * Phone number: 	    +359 888 55 55 555
 * Fax number: 	        2
 * Web site: 	        http://telerikacademy.com/
 * Manager first name: 	Nikolay
 * Manager last name: 	Kostov
 * Manager age: 	    25
 * Manager phone: 	    +359 2 981 981
 * 
 * Example output:
 * Telerik Academy
 * Address: 231 Al. Malinov, Sofia
 * Tel. +359 888 55 55 555
 * Fax: (no fax)
 * Web site: http://telerikacademy.com/
 * Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)
 */

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        string companyName, companyAddress, phone, fax, webSite, managerFName, managerLName, managerAge, managerPhone;
        Console.Write("Company name: ");
        companyName = Console.ReadLine();
        Console.Write("Company address: ");
        companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        phone = Console.ReadLine();
        Console.Write("Fax number: ");
        fax = Console.ReadLine();
        Console.Write("Web site: ");
        webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        managerFName = Console.ReadLine();
        Console.Write("Manager last name: ");
        managerLName = Console.ReadLine();
        Console.Write("Manager age: ");
        managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        managerPhone = Console.ReadLine();
        Console.WriteLine(new String('=', 40));
        Console.WriteLine(companyName);
        Console.WriteLine(companyAddress);
        Console.WriteLine(phone);
        Console.WriteLine(fax);
        Console.WriteLine(webSite);
        Console.WriteLine(managerFName);
        Console.WriteLine(managerLName);
        Console.WriteLine(managerAge);
        Console.WriteLine(managerPhone);
    }
}