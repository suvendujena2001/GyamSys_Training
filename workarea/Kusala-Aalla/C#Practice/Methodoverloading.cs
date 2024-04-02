using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total;

            total = Multiply(2, 3, 4);
            Console.WriteLine(total);
            Console.ReadLine();
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
