/*
 * Problem 4. Unicode Character
 * Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then
 * print it.
 * Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *
 */

using System;

class UnicodeChar
{
    static void Main()
    {
        char Symbol;
        Symbol = '\u002A'; //Unicode escape sequence uses hexadecimal number (source: https://msdn.microsoft.com/en-us/library/aa664669%28v=vs.71%29.aspx); 42d = 2Ah.
        Console.WriteLine("Символът с код 42 в unicode таблицата е \"" + Symbol + "\"");
    }
}