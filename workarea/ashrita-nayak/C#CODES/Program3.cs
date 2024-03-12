// See https://aka.ms/new-console-template for more information
using System;
namespace TypesOfVariables
{
    internal class Program
    {
        static int x = 225; 
        int y = 943;
         static string StringVar = "I had my lunch.";
        static int intVar = 99;
        static float floatVar = 347.9f;
        static char charVar = 'S';
        static bool boolVar = true;
        static void Main(string[] args)
        {
            Console.WriteLine($"x value: {x}");
            Program obj = new Program();
            Console.WriteLine($"y value: {obj.y}");
            Console.WriteLine($"StringVar value: {StringVar}");
            Console.WriteLine($"intVar value: {intVar}");
            Console.WriteLine($"floatVar value: {floatVar}");
            Console.WriteLine($"charVar value: {charVar}");
            Console.WriteLine($"boolVar value: {boolVar}");

        }
    }
}

