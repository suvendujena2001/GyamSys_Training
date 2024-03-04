using System;

class Program
{
    static void Main()
    {
        double number = 0;
        int maxAttempts = 3;

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.Write($"Attempt {attempt}: Enter a number: ");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out number))
            {
                
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        
        if (double.IsNaN(number))
        {
            Console.WriteLine($"You've exceeded the maximum number of attempts. Exiting program.");
        }
        else
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
    }
}
