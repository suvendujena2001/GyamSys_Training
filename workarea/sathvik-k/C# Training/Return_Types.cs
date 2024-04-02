using System;

class Program
{
    static void Main()
    {
        
        int number = 10;
        
        if (IsEven(number))
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

  
    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
}
