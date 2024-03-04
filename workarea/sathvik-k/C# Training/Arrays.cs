using System;

class Program
{
    static void Main()
    {
      // Multi-dimensional array
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Printing elements of the 2D array:");

        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

      // Jagged array
        int[][] jaggedArray = new int[3][];

        
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5, 6, 7 };
        jaggedArray[2] = new int[] { 8, 9 };

        Console.WriteLine("Printing elements of the jagged array:");

        
        foreach (var subarray in jaggedArray)
        {
            foreach (var element in subarray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

      static void Main()
    {
      
        PrintNumbers(1, 2, 3, 4, 5);
    }

    static void PrintNumbers(params int[] numbers)
    {
        Console.WriteLine("Printing numbers using param array:");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
      }
    }
}
