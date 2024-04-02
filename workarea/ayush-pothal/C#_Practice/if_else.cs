using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the time:");
            int time = Convert.ToInt32(Console.ReadLine());

            if (time > 0 && time < 12)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time > 12 && time < 16)
            {
                Console.WriteLine("Good afternoon.");
            }
            else if (time > 16 && time < 24)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Enter a valid time");
            }
        }
    }
}
