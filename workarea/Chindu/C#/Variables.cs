/*Variables:
Variables in C# are containers for storing data values.
They have a data type and a unique name.
The value of a variable can be changed during the execution of the program.*/

int age = 25; // Declaring an integer variable named 'age' with a value of 25

/*Constants:
Constants are variables whose values cannot be changed during the execution of the program.
They are declared using the const keyword.*/

const double PI = 3.14; // Declaring a constant named 'PI' with a value of 3.14

/*Display Variables:
Displaying variables involves outputting their values, often to the console for debugging or user interaction.
This is usually done using methods like Console.WriteLine().*/

Console.WriteLine($"The value of age is: {age}");

/*Multiple Variables:
Multiple variables can be declared and initialized in a single statement.
This is particularly useful when variables of the same type need to be declared.*/

int x = 10, y = 20, z = 30; // Declaring and initializing multiple integer variables

/*Identifiers:
Identifiers are names given to variables, constants, methods, classes, etc. in C#.
They must follow certain rules:
Start with a letter or underscore.
Consist of letters, digits, or underscores.
Cannot contain whitespace or special characters (except underscores).
Cannot be a reserved keyword.*/

int _totalAmount; // Valid identifier starting with an underscore
double averageScore; // Valid identifier consisting of letters and digits

using System;

class Program
{
    static void Main()
    {
        // Variables
        int age = 25;
        double height = 5.8;

        // Constants
        const double PI = 3.14;

        // Display Variables
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");

        // Multiple Variables
        int x = 10, y = 20, z = 30;

        // Identifiers
        int _totalAmount = 100;
        double averageScore = 85.5;

        Console.WriteLine($"Sum of x, y, and z: {x + y + z}");
        Console.WriteLine($"Value of PI: {PI}");
        Console.WriteLine($"Total amount: {_totalAmount}");
        Console.WriteLine($"Average score: {averageScore}");
    }
}

