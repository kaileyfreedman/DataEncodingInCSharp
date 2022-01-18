using System;

namespace DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            ch = 'A';
            Console.WriteLine($"ch is storing the value: {ch}");

            int ch_decimal;
            ch_decimal = ch;
            Console.WriteLine($"The decimal value of ch is: {ch_decimal}");

            int toConvert;
            Console.WriteLine("Enter an integer: ");
            toConvert = int.Parse(Console.ReadLine());

            char asChar;
            asChar = (char)toConvert;
            Console.WriteLine($"The interger {toConvert} cast to char is '{asChar}'");

            char b;
            b = (char)('A' + 1);
            Console.WriteLine($"'A' + 1 = '{b}'");

            char z;
            z = (char)('Z'+3);
            Console.WriteLine($"'Z' + 3 = '{z}'");

            char f;
            f = (char)('F'-5);
            Console.WriteLine($"'F' - 5 = '{f}'");
        }
    }
}
