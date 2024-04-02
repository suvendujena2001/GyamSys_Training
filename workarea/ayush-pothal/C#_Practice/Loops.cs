using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter the value of i:");
            int i = Convert.ToInt32(Console.ReadLine());

            //do while loop
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);


            //while loop
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }

            
            //for loop 
            for(int j=0;j<10; j++) 
            { 
                Console.WriteLine(j);
            }


            //foreach loop
            int[] fruits = {2,4,6,8,0 };
            foreach (int fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
