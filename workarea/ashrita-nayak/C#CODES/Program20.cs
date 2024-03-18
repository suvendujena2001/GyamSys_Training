using System;
using System.Linq;
using System.Collections.Generic;

class Numerology
{
    static void Main()
    {
        List<int> numbers = new List<int> { 39, 67, 34, 23, 58, 21, 45, 87, 12, 98};
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;
        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
