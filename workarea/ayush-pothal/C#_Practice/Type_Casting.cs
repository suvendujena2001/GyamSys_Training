using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //implicit Casting

            int myInt1 = 100;
            double myDouble1 = myInt1;   
            long myLong1 = myInt1;

            Console.WriteLine(myInt1);      
            Console.WriteLine(myDouble1);
            Console.WriteLine(myLong1);

            //explicit Casting

            double myDouble2 = 5.43;
            int myInt2 = (int)myDouble2;
            Console.WriteLine(myDouble2);   
            Console.WriteLine(myInt2);


            string myString1 = myDouble2.ToString();
            Console.WriteLine(myString1);

            Console.ReadLine();

        }
    }
}
