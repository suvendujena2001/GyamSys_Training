using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        public int Funct(params int[] arr1)//Params Array
        {
            int sum = 0;
            foreach (int i in arr1)
            {
                sum += i;

            }
            return sum;
            
        }
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];//Jagged Array
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 2, 3 };
            jaggedArray[2] = new int[] { 3, 4, 5, 6 };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
            Program app= new Program();
            int sum = app.Funct(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
            
            
            
        }
    }

