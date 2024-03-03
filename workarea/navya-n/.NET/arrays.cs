using System;
class Arrays
{
    static void Main()
    {
        // Declaring and initializing an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Accessing elements of an array
        Console.WriteLine(numbers[0]); // Output: 1
        Console.WriteLine(numbers[4]); // Output: 5

        // Modifying elements of an array
        numbers[2] = 10;
        Console.WriteLine(numbers[2]); // Output: 10

        // Using a for loop to iterate over an array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.ReadLine();
    }
}
