using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1D Array
            int[] Array_1D = { 2, 4, 1, 5, 6, 9, 7 };

            // OR
            // int[]Array_1D=new int[];
            // Array_1D[0]=0;Array_1D[1]=1;....

            for (int i = 0; i < Array_1D.Length; i++)
            {
                Console.Write(Array_1D[i]+" ");
            }

            //sorting an array

            Array.Sort(Array_1D);

            for (int i = 0; i < Array_1D.Length; i++)
            {
                Console.Write(Array_1D[i]+" ");
            }

            //2D Array

            int[,] Array_2D = { { 1, 3, 5 }, { 2, 4, 6 } };

            // OR
            // int [,] Array_2D = new int[2,3];
            // Array_2D[0,0]=0; Array_2D[0,1]=1.....

            for (int i = 0; i < Array_2D.GetLength(0); i++)
            {
                for (int j = 0; j < Array_2D.GetLength(1); j++)
                {
                    Console.Write(Array_2D[i, j]+" ");
                }
                Console.WriteLine();
            }

            foreach (int num in Array_2D)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();

            //Jagged Array- A jagged array is an array of arrays, where each sub-array can have a different size.

            int[][] jaggedMatrix = new int[2][];
            jaggedMatrix[0] = new int[] { 1, 2, 3 };
            jaggedMatrix[1] = new int[] { 4, 5 };
            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                for (int j = 0; j < jaggedMatrix[i].Length; j++)
                {
                    Console.Write(jaggedMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            //Param Array - Param arrays allow a method to accept a variable number of arguments of the same data type.

             int Sum(params int[] param_Array)
            {
                int total = 0;
                foreach (int num in param_Array)
                    total += num;
                return total;
            }

            int result = Sum(1, 2, 3, 4, 5); 
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
