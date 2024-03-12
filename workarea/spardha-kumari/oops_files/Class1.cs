using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class BaseClass
    {
        static BaseClass()
        {
            Console.WriteLine("BaseClass static block");
        }

        public BaseClass()
        {
            Console.WriteLine("BaseClass constructor");
        }

        /*static BaseClass()
        {
            Console.WriteLine("Another BaseClass static block");
        }*/

        public BaseClass(int value)
        {
            Console.WriteLine("BaseClass overloaded constructor with value: " + value);
        }
    }

    class DerivedClass : BaseClass
    {
        static DerivedClass()
        {
            Console.WriteLine("DerivedClass static block");
        }

        public DerivedClass() : base()
        {
            Console.WriteLine("DerivedClass constructor");
        }

        public DerivedClass(int value) : base(value)
        {
            Console.WriteLine("DerivedClass overloaded constructor with value: " + value);
        }

        /*static DerivedClass()
        {
            Console.WriteLine("Another DerivedClass static block");
        }*/

        /*{
            Console.WriteLine("DerivedClass instance block");
        }*/

        public DerivedClass(int value, string message) : this()
        {
            Console.WriteLine("DerivedClass constructor with message: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass(1, "Hello");
            Console.Read();
        }
    }
}



