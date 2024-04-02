using System;

//multi-dimensional array illustration

int[,] matrix = new int[5, 3];
// assign integers to the 2D array
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
    }
}
// output the 2D array
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}");
        Console.Write(j < matrix.GetLength(1) - 1 ? "," : "");
    }
    Console.WriteLine();
}




//jagged array illustration
int[][] arr = new int[2][];// Declare the array  

        arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
        arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

        // Traverse array elements  
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
}


object[] obj = new object[6];
obj[0] = 1;
obj[1] = "Two";
obj[2] = 3;
obj[3] = "Four";
obj[4] = 5;
obj[5] = "Six";

PrintValues(obj);
 static void PrintValues(params object[] obj)
{
    foreach (object o in obj)
        Console.WriteLine(o.ToString());
}