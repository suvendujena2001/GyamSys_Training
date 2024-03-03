using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {

        //Method without any parameters
        static void myMethod1()
        {
            Console.WriteLine("Hello everyone!");
        }

        //Method with parameters
        static void myMethod2(string fname, string lname)
        {
            Console.WriteLine(fname +" "+ lname);
        }
        static void Main(string[] args)
        { 
                myMethod1();
                myMethod2("Ayush", "Pothal");

                //Named Arguments
                myMethod2(lname: "Sahu", fname: "Swagat");
        
        }
    }
}
