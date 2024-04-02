using System;
 
public class Program
{
    public static void Main()
    {
        // Creating a jagged array
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
 
        // Accessing elements of the jagged array
        Console.WriteLine(jaggedArray[0][0]); // Output: 1
        Console.WriteLine(jaggedArray[1][1]); // Output: 5
        Console.WriteLine(jaggedArray[2][3]); // Output: 9
 
        Console.ReadLine();
    }
}