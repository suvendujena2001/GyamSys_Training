using System;
 
public class Program

{

    public static void Main()

    {

        // Creating a 2D array

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
 
        // Accessing elements of the 2D array

        Console.WriteLine(matrix[0, 0]); // Output: 1

        Console.WriteLine(matrix[1, 2]); // Output: 6
 
        // Creating a 3D array

        int[,,] cube = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
 
        // Accessing elements of the 3D array

        Console.WriteLine(cube[0, 1, 2]); // Output: 6

        Console.WriteLine(cube[1, 0, 1]); // Output: 8
 
        Console.ReadLine();

    }

}


