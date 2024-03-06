// See https://aka.ms/new-console-template for more information

using System;

namespace first
{
    namespace NestName
    {
        // class within nested namespace	 
        class LetsCodeClass
        {
            public LetsCodeClass()
            {

                Console.WriteLine("CODING IS IMPORTANT AND FUN.....");
            }
        }
    }
    class backend_1
    {

        public static void display()
        {
           System.Console.WriteLine("Welcome to backend development!");
        }
    }
} 

class dotnet1
{
    public static void Main(String[] args)
    {
        first.backend_1.display();
        new first.NestName.LetsCodeClass();
    }
}
