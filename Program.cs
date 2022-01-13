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
        }
    }
}
