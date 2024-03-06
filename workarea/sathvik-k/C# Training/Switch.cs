using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();


        if (double.TryParse(userInput, out double number))
        {
          
            switch (Math.Sign(number))
            {
                case 1:
                    Console.WriteLine("The entered number is positive.");
                    break;
                case -1:
                    Console.WriteLine("The entered number is negative.");
                    break;
                case 0:
                    Console.WriteLine("The entered number is zero.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
