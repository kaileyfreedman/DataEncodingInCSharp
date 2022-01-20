using System;

namespace DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher;
            cipher = new Cipher(5);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encrypted message is: '{encrypted}'");
            
            string decrypted;
            decrypted = cipher.Decrypt(encrypted);
            Console.WriteLine($"The decrypted message is: '{decrypted};'");
            
            string message;
            message = System.IO.File.ReadAllText("secrets/1.txt");
            Console.WriteLine($"The encrypted message is: '{message}'."); 

            decrypted = cipher.Decrypt(message);
            Console.WriteLine($"The decryped message is: '{decrypted}'");
            int shift;
            shift = 1;
            while (shift <= 10)
            {
                Cipher cipher3;
                cipher3 = new Cipher(shift);
                decrypted = cipher3.Decrypt(message);
                Console.WriteLine($"The decrypted message is: '{decrypted}'");
                shift += 1;
            }

        }
    }
}

