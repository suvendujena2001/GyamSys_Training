using System;
 
public class Program
{
    public static void Main()
    {
        int result = Add(3, 5);
        Console.WriteLine("The result is: " + result);
    }
 
    public static int Add(int a, int b)
    {
        return a + b;
    }
}