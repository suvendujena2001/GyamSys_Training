using System;

namespace MyApp
{
    internal class DataTypes
    {
        public void displayDataTypes()
        {
            //Character literal using single quote
            char ch1 = 'A';
            Console.WriteLine("Single Quote: " + ch1);
            //Character literal using Unicode representation
            char ch2 = '\u0041';
            Console.WriteLine("Unicode: " + ch2);
            //Character literal using Escape character
            Console.WriteLine("Escape: Hello\nDotNet\tTutorials");
            // Decimal literal
            //Allowed Digits: 0 to 9
            int a = 101; //No suffix is required
                         // Hexa-Decimal Literal
                         //Allowed Digits: 0 to 9 and Character a to f
            int b = 0x123f; //Prefix with 0x, and suffix with f
                            //Binary literal
                            //Allowed Digits: 0 to 1
            int c = 0b1111; // //Prefix with 0b
            Console.WriteLine($"Decimal Literal: {a}");
            Console.WriteLine($"Hexa-Decimal Literal: {b}");
            Console.WriteLine($"Binary Literal: {c}");
            int d = 1000; //Integer
            uint e = 1000U; //Unsigned Integer
            long f = 1000L; //Long
            ulong g = 1000UL; //Unsigned Long

            Console.WriteLine($"Integer Literal: {d}");
            Console.WriteLine($"Unsigned Integer Literal: {e}");
            Console.WriteLine($"Long Literal: {f}");
            Console.WriteLine($"Unsigned Long Literal: {g}");
            //Double Literal
            double h = 10.15; //By Default Floating Point Literal is double
                              //Float Literal
            float i = 100.72F; //Suffix with F
                               //Double Literal
            double j = 1.45D; //Suffix with D
                              //Decimal Literal
            decimal k = 1.44M; //Suffix with M

            Console.WriteLine($"Double Literal: {h}");
            Console.WriteLine($"Float Literal: {i}");
            Console.WriteLine($"Double Literal: {j}");
            Console.WriteLine($"Decimal Literal: {k}");

            string str1 = "Dot Net Tutorials";
            string str2 = @"Dot Net Tutorials";
            string str3 = "Dot\nNet\tTutorials";
            string str4 = @"Dot\nNet\tTutorials";
            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");
            Console.WriteLine($"str3: {str3}");
            Console.WriteLine($"str4: {str4}");

            bool b1 = true;
            bool b2 = false;
            // bool b3 = 0; //Error
            // bool b4 = 1; //Error 
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
