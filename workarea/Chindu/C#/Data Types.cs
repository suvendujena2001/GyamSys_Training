//A data type specifies the size and type of variable values.

using System;

class Program
{
    static void Main()
    {
        // Value Types
        int age = 25;
        float height = 5.8f;
        double weight = 68.5;
        decimal salary = 50000.75m;
        byte red = 255;
        bool isStudent = true;
        char grade = 'A';

        // Reference Types
        string name = "John Doe";
        int[] numbers = { 1, 2, 3, 4, 5 };
        string[] fruits = { "apple", "banana", "orange" };

        // Class Types
        Person person = new Person { Name = "Alice", Age = 30 };

        // Output
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Weight: {weight}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Red: {red}");
        Console.WriteLine($"Is Student: {isStudent}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Fruits: " + string.Join(", ", fruits));
        Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");
    }
}


