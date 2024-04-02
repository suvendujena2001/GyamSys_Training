using System;

class Program
{
    static void Main()
    {
        // If-Else
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("Number is positive.");
        }
        else
        {
            Console.WriteLine("Number is non-positive.");
        }
        // Output: Number is positive.

        // Switch
        int dayOfWeek = 3;
        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
        // Output: Wednesday

        // While
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        // Output:
        // 0
        // 1
        // 2
        // 3
        // 4

        // Do While
        int j = 0;
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j < 5);
        // Output:
        // 0
        // 1
        // 2
        // 3
        // 4

        // For
        for (int k = 0; k < 5; k++)
        {
            Console.WriteLine(k);
        }
        // Output:
        // 0
        // 1
        // 2
        // 3
        // 4

        // Foreach
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        // Output:
        // 1
        // 2
        // 3
        // 4
        // 5
    }
}
