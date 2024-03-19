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
            //forloop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loop nr "+ i);
            }

            //Foreach
            string[] names = new string[4] { "hello", "world", "welcome", "program" };
             
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //whileloop
            int num01 = 0;

            while (num01 <10)
            {
                Console.WriteLine(" Loop nr " + num01);
                num01++;
            }

            //dowhile
            int num02 = 0;

            do
            {
                Console.WriteLine(" Loop nr " + num02);
                num02++;
            } while (num02 < 10);
        }
    }
}
