using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        interface IStudent
        {
            void Program();
        }

        class Undergraduate : IStudent
        {
            public void Program()
            {
                Console.WriteLine("Undergrad Program");
            }
        }

        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate();
            undergraduate.Program();
            Console.ReadLine();
        }
    }
}
