using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            derivedclass2 der=new derivedclass2();
            der.input();
            der.milage();
            der.remaining();
            der.output();
            Console.Read();

        }
    }
    class baseclass 
    {
        public void output()
        {
            Console.WriteLine("Base class called.\n");
        }


        public double dist;
        public void input()
        {
            output();
            Console.WriteLine("Enter starting point:");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the ending point:");
            double b=Convert.ToDouble(Console.ReadLine());
            dist = b - a;
            Console.WriteLine($"Distance between two points is: {dist}");
        }
    }

    class derivedclass : baseclass  //Single level Inheritance
    {
        public void output() //Function Overriding
        {
            Console.WriteLine("\nDerived class-1 called.\n");
        }

        public double mil;
        public void milage()
        {
            output();
            Console.WriteLine("Enter the amount of fuel:");
            double f=Convert.ToDouble(Console.ReadLine());
            mil = dist / f;
            Console.WriteLine($"Milage is: {mil}");
        }

    }

    class derivedclass2:derivedclass  //Multilevel Inheritance
    {
        public void output() //Function Overriding
        {
            Console.WriteLine("\nExecution Fished!!!");
        }

        public double remain;
        public void remaining()
        {
            Console.WriteLine("\nEnter the total feul capacity:");
            double rem=Convert.ToDouble(Console.ReadLine());
            remain = rem*mil;
            Console.WriteLine($"Toatal distance: {remain}");
        }
    }

}
