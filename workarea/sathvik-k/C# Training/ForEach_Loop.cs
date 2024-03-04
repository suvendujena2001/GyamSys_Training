using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string userInput = Console.ReadLine();


        string[] inputNumbers = userInput.Split(' ');

        foreach (string inputNumber in inputNumbers)
        {
            
            if (double.TryParse(inputNumber, out double number))
            {
                
                if (number > 0)
                {
                    Console.WriteLine($"{number} is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"{number} is negative.");
                }
                else
                {
                    Console.WriteLine($"{number} is zero.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid input: {inputNumber}. Skipping.");
            }
        }
    }
}
