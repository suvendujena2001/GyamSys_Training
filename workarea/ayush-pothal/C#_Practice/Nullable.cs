using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration & Initialization
            int? a = null; 
            int? b = 10;
            bool? isBool = null;

            //Properties of Nullable datatype
            if (b.HasValue)
            {
                Console.WriteLine($"b is {b.Value}");
            }
            else
            {
                Console.WriteLine("b does not have any value");
            }


            // GetValueOrDefault(-1) Method
            int? c = null;
            Console.WriteLine($"c is {c.GetValueOrDefault(-1)}"); 


            //Explicit Casting
            int? d = 123;
            int e = (int)d; 
            Console.WriteLine($"e is {e}");



        }

    }
}
