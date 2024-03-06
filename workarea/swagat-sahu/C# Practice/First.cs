using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is " + a + b);
            Console.WriteLine("The product of the numbers is " + a * b);
            
            if(a > 10)
            {
                Console.WriteLine( "It's a great number!");
            }
            else
            {
                Console.WriteLine( "It's not a great number!");
            }
            
            while(a < 10)
            {
                Console.WriteLine("Hello Everyone!");
                a++;
            }
            for(int i = 0; i < a; i++) 
            {
                Console.WriteLine("It's a for loop!");
            
            }
            int[] arr1 = { 1, 22, 333, 4444, 55555 };
            foreach(int i in arr1)
            {
                Console.WriteLine(i);            }
            
            string Name1 = "Amit";
            int Age1 = 22;
            HappyBirthday(Name1, Age1);
            int[,] n = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    Console.WriteLine(n[i, j]);
                }
            }
            Console.ReadLine();
        }
        static void HappyBirthday(string Name, int Age) 
        {
            Console.WriteLine("Happy Birthday " + Name + ", You are " + Age + " Years old.");
        }
    }

}