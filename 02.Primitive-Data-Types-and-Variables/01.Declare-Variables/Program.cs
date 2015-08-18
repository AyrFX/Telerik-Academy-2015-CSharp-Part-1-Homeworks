/* 
 * Problem 1. Declare Variables
 * Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long,
 * ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
 * Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 * Submit the source code of your Visual Studio project as part of your homework submission.
 */

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort uShortNumber = 52130; //range: 0 to 65,535
        sbyte sbyteNumber = -115; //range: -128 to 127
        int intNumber = 4825932; //range: -2,147,483,648 to 2,147,483,647; uint can be used also and cost the same amount of memory
        byte byteNumber = 97; //range: 0 to 255
        short shortNumber = -10000; //range: -32,768 to 32,767
        // source: http://msdn.microsoft.com/en-us/library/exx3b86w.aspx
    }
}
