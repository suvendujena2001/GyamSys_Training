using System;

class Program
{
    static void Main()
    {
        // Declaring and initializing a variable with a value
        int a = 10;
        Console.WriteLine("Value of a: " + a);

        // Declaring a variable without initializing it
        int b;
        
        // Initializing the variable later
        b = 20;
        Console.WriteLine("Value of b: " + b);

        // Declaring and initializing a variable with an expression
        int c = a + b;
        Console.WriteLine("Value of c: " + c);

        // Declaring a constant variable
        const int d = 50;
        Console.WriteLine("Value of d: " + d);

        // Using the var keyword to let the compiler infer the type
        var f = 30;
        Console.WriteLine("Value of f: " + f);
        Console.ReadLine();
    }
}
