using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_app
{
   /*  class Point
    {
        internal int x;
        internal int y;
        public void Test()
        {
            Point p = new Point();
            
        }

    }*/

    class Car
    {
        internal string model;
        internal string color;
        internal int price;

        internal void PrintInfo()
        {
            Console.WriteLine("Model"+model); Console.WriteLine("color"+color);
            Console.WriteLine("price"+price); 
            Console.WriteLine("see how the internal access modifiers work");
            Console.ReadLine();
        }
    }

    //class Program:Point { 
    class Program { 
        static void Main()
        {
           // Point p1 = new Point();
            Program p2 = new Program();
            Car c1 = new Car();
            c1.model = "Ferrari";
            c1.color = "Pink";
            c1.price = 500000000;
            c1.PrintInfo();


            

        }
    }
}
/*namespace N
{
    class Sample
    {
        public void Display()
        {
            Oops_app.Point p = new Oops_app.Point();
           // p.x and p.y can be accessed.
        }
        public static void Main() { }
    }
}
*/