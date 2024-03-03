using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_In_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            // ways to create an array

            String[] cars2 = new String[4];
            string[] cars3 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars4 = new String[4] { "Volvo", "BMW", "Ford", "Mazda" };

            //loop through the array
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            /*
             Multi dimensional array -
            To create a 2D array :
            int [,] numbers = {{1,4,2} , {3,6,8}};

            For 3D array : int [, ,] arr = { {} {} {}};

             */
            
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            /*
            Console.WriteLine(arr[0,2]);

            // looping through 2D 

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            */

            // using for loop ....

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i,j]);
                }
            }
            Console.WriteLine();


            /* Jagged array : 
             * is a array of arrays
             * each member is of different size
             * here no. of rows will be fixed during declaration but no. of columns can vary.
             * 
             * Syntax : int [][] jagged_arr = new int[4][]
             * in the above example , a single dimensional array is declared that has 4 elements,each of which is 1D array.
             * 
             * 
             */
            int[][] jagged_arr = new int[4][];

            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 4, 5, };
            jagged_arr[2] = new int[] { 5, 6, 7 };
            jagged_arr[3] = new int[] { 7, 8, 9, 10 };

            // display array elements 

            for(int n=0;n<jagged_arr.Length;n++)
            {
                Console.Write("Row[{0}): ", n);

                for (int k = 0; k < jagged_arr[n].Length; k++)
                {
                    Console.Write(" {0} ", jagged_arr[n][k]);
                }
                Console.WriteLine();
            }

            // Jagged array with Multi dimensional Array


            int[][,] jagged_arr1 = new int[4][,]
            {
                new int[,] {{1,3},{5,7}},
                new int[,] {{0,2} , { 2, 4 },{ 4, 6 } },
                new int[,] {{0,1} , { 2, 5 }, {  4, 6 } },
                new int[,] {{0,2}}

            };

            for(int i = 0; i < jagged_arr1.Length; i++)
            {
                int x = 0;
                for(int j = 0; j < jagged_arr1[i].GetLength(x); j++)
                {
                    for (int k = 0; k < jagged_arr1[j].Rank; k++)
                        Console.Write("Jagged_Array[" + i + "][" + j + ", " + k + "]: "
                                                    + jagged_arr1[i][j, k] + " ");
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
            /* 
             Params Array :
            It is used as a parameter which can take the variable number of arguments.
            Useful for the program when we dont know thw number of parameter that will be used.

             */


            
            int y = Add(1,2,3,4,5);

            Console.WriteLine(y);

        }
        public static int Add(params int[] arr)
        {
            int total = 0;
            foreach (int i in arr)
            {
                total += i;
            }
            return total;
        }
    }
    
    
       
    
}
