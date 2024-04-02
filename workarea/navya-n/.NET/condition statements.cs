//If else statement
using System;
class Program
{
    static void Main()
    {
        int num = 10;

        if (num % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }

        Console.ReadLine();
    }
}

//While and Do while
using System;
class Program
{
    static void Main()
    {
        int i = 0;

        // while loop
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }

        Console.WriteLine();

        // do-while loop
        int j = 0;
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j < 5);

        Console.ReadLine();
    }
}

//For loop
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.ReadLine();
    }
}
/*class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}*/
