using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp
{
    internal class StaticDemo
    {
        int x = 100;
        static int y = 200;
        public static void Add()
        {
            //This is a static block
            //we can access non static members X with the help of Example object
            //We can access the static member directly or through class name
            StaticDemo obj = new StaticDemo();
            //Console.WriteLine(obj.x + Example.y);
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + y));
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + StaticDemo.y));
        }
        public void Mul()
        {
            //This is a Non-Static method
            //we can access static members directly or through class name
            //we can access the non-static members directly or through this keyword
            Console.WriteLine("Multiplication of 100 and 200 is :" + (this.x * StaticDemo.y));
            Console.WriteLine("Multiplication of 100 and 200 is :" + (x * y));
        }


    }
}
