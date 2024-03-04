using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

       
        if (double.TryParse(userInput, out double number))
        {
            
            if (number > 0)
            {
                Console.WriteLine("The entered number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The entered number is negative.");
            }
            else
            {
                Console.WriteLine("The entered number is zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
