using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Add(double a, double b, double c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int sum1 = Add(10, 20);
            int sum2 = Add(20, 30, 40);
            double sum3 = Add(30.2, 40.5, 50);


            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.ReadLine();

        }
    }
}
