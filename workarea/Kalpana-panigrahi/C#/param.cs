using System;
 
public class Program
{
    public static void Main()
    {
        // Calling a method with a param array
        PrintNumbers(1, 2, 3);
        PrintNumbers(4, 5, 6, 7, 8);
 
        Console.ReadLine();
    }
 
    public static void PrintNumbers(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }