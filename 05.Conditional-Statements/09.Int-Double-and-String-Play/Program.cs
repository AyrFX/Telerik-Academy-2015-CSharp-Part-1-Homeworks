/*
 * Problem 9. Play with Int, Double and String
 * Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
 * Print the result at the console. Use switch statement.
 * 
 * Example 1:
 * program 	                user
 * Please choose a type: 	
 * 1 --> int 	
 * 2 --> double 	
 * 3 --> string 	        3
 * Please enter a string: 	hello
 * hello* 	
 * 
 * Example 2:
 * program 	                user
 * Please choose a type: 	
 * 1 --> int 	
 * 2 --> double 	        2
 * 3 --> string 	
 * 
 * Please enter a double: 	1.5
 * 2.5 	
 */

using System;

class IntDoubleStringGame
{
    static void Main()
    {
        Console.Write("Please choose a type (1 --> int; 2 --> double; 3 --> string): ");
        byte choice;
        byte.TryParse(Console.ReadLine(), out choice);
        switch (choice)
        {
            case 1:
                Console.WriteLine("Please enter a int: ");
                int intNumber;
                int.TryParse(Console.ReadLine(), out intNumber);
                Console.WriteLine(++intNumber);
                break;
            case 2:
                Console.WriteLine("Please enter a double: ");
                double dblNumber;
                double.TryParse(Console.ReadLine(), out dblNumber);
                Console.WriteLine(++dblNumber);
                break;
            case 3:
                Console.WriteLine("Please enter a text: ");
                string text = Console.ReadLine();
                Console.WriteLine(text + '*');
                break;
            default:
                Console.WriteLine("wrong choice!");
                break;
        }
    }
}