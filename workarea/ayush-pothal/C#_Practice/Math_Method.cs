using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = -30;
            float f = 8.60F;

            Console.WriteLine(Math.Max(x,y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Abs(z));
            Console.WriteLine(Math.Sqrt(x));
            Console.WriteLine(Math.Round(f));


        }
    }
}
