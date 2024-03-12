/*Value Types:
Value types directly contain their data, and instances of value types are stored in memory where they are declared or in a stack.
When you create a variable of a value type, the actual value is stored in that variable.
Value types are typically simple types like integers, floating-point numbers, characters, and structs.
Examples of value types include int, float, double, char, bool, struct, etc.*/

/*Reference Types:
Reference types store references to their data (objects), and instances of reference types are stored in memory heap.
When you create a variable of a reference type, the variable holds a reference (memory address) to where the actual data is stored.
Reference types include class types, interface types, delegate types, and array types.
Examples of reference types include string, object, user-defined classes, interfaces, arrays, etc.*/

using System;

class Program
{
    static void Main()
    {
        // Value Type Example
        int age = 25;  // Value type variable 'age' storing the value 25
        char grade = 'A'; // Value type variable 'grade' storing the character 'A'

        // Reference Type Example
        string name = "John";  // Reference type variable 'name' storing a reference to the string "John"
        object obj = new object(); // Reference type variable 'obj' storing a reference to a new object

        // Displaying Values
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Object: {obj}");

        // Checking Types
        Console.WriteLine($"Type of 'age': {age.GetType()}");
        Console.WriteLine($"Type of 'grade': {grade.GetType()}");
        Console.WriteLine($"Type of 'name': {name.GetType()}");
        Console.WriteLine($"Type of 'obj': {obj.GetType()}");
    }
}
