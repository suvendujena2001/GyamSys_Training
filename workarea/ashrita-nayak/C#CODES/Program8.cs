// See https://aka.ms/new-console-template for more information
using System;
namespace Method
{
    class Program
    {
        // method declaration
         
        public void display()
        {
            Console.WriteLine("The planet Earth is a beautiful place to live in.");
        }
        static void Main(string[] args)
        { 
            Program p1 = new Program();
            p1.display();
          ;

            int z = MyMethod(23,89);
            Console.WriteLine(z);
        }
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

    }
}


