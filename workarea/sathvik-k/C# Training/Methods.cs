using System;

class Program
{
    static void Main()
    {
        double number = GetUserInput();
        DetermineAndDisplayNumberType(number);
    }

    static double GetUserInput()
    {
        double userInput;

        do
        {
            Console.Write("Enter a number: ");
        } while (!double.TryParse(Console.ReadLine(), out userInput));

        return userInput;
    }

    static void DetermineAndDisplayNumberType(double number)
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
}
