<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.NET__Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 19;
            char c= 'A';
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine("First Console App");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");// next line and tab spaces
            Console.Write(@"     c:\invoices");// for ignoring mulitple spaces
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); //unicode

            //String concatenation
            string firstName = "Bob";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + firstName + "!");

            //string interpolation
            string message = $"{greeting} {firstName}!";
            Console.WriteLine(message);

            //variables
            string name = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(name + " sold " + widgetsSold + " widgets.");

            //decimal
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);

            //increment
            int value = 0;     // value is now 0.
            value = value + 5; // value is now 5.
            value += 5;
            Console.WriteLine(value);

            //Math class
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);

            Console.Read();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.NET__Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 19;
            char c= 'A';
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine("First Console App");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");// next line and tab spaces
            Console.Write(@"     c:\invoices");// for ignoring mulitple spaces
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); //unicode

            //String concatenation
            string firstName = "Bob";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + firstName + "!");

            //string interpolation
            string message = $"{greeting} {firstName}!";
            Console.WriteLine(message);

            //variables
            string name = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(name + " sold " + widgetsSold + " widgets.");

            //decimal
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);

            //increment
            int value = 0;     // value is now 0.
            value = value + 5; // value is now 5.
            value += 5;
            Console.WriteLine(value);

            //Math class
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);

            Console.Read();
        }
    }
}
>>>>>>> origin/main
