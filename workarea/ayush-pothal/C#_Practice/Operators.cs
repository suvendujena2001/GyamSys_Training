using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Artithmetic Operators
            int x = 11;
            int y = 2;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);

            //Assignment Operators
            int a = 10;
            int b=a;
            int c = 0;
            c += 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


            //Comparision Operators
            int x2 = 5;
            int y2 = 7;
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x = y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x >= y);


            //Logical Operators
            int m = 10;
            Console.WriteLine(m > 5 && m < 15);
            Console.WriteLine(m > 5 || m < 15);
            Console.WriteLine(!(m > 5 && m < 15));


            Console.ReadLine();
        }
    }
}
