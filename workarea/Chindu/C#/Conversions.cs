//Implicit Conversions - Implicit conversions are performed automatically by the compiler when there's no risk of losing information or precision.

using System;

class Program
{
    static void Main(string[] args)
    {
        int numInt = 10;
        double numDouble;

        // Implicit conversion from int to double
        numDouble = numInt;

        Console.WriteLine("Implicitly converted double value: " + numDouble);
    }
}

//Explicit Conversion
//Explicit conversions require a cast operator and are performed when there's a risk of losing information or precision.

using System;

class Program
{
    static void Main(string[] args)
    {
        double numDouble = 10.5;
        int numInt;

        // Explicit conversion from double to int
        numInt = (int)numDouble;

        Console.WriteLine("Explicitly converted integer value: " + numInt);
    }
}
