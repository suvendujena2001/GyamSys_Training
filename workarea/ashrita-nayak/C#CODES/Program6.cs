// See https://aka.ms/new-console-template for more information
using System;
namespace Conditional
{
    class CondStatement
    {
        public static void Main(string[] args)
        {
            //if statement execution 
            int number = 4;
            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            Console.WriteLine("This statement is always executed.");

            //if - else statement execution
            int digit = 78;
            if (digit < 5)
            {
                Console.WriteLine("{0} is less than 5", digit);
            }
            else
            {
                Console.WriteLine("{0} is greater than or equal to 5", digit);
            }

            Console.WriteLine("This statement is always executed.");

            //for statement execution
            for (int i = 1; i < 12; i++)
            {
                Console.Write(i + " \n ");
            }

            //for each statement execution

            int[] values = { 243,786,009,10567 };

            foreach (int value in values)
            {
                Console.Write(value + " \n");
            }

            //while statement execution
            int u = 3;
            while (u < 13)
            {
                Console.Write(u + " \n");
                u++;
            }

            //do-while statement execution
            int v = 99;
            do
            {
                Console.Write(v + "\n ");
                v++;
            } while (v < 110);
        }

    }
    
} 

