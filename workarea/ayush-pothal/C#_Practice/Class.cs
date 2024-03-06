using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {

        class Person
        {
            public string Name; 
            public int Age;    

            public void DisplayInfo() 
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Ayush";
            person1.Age = 22;
            person1.DisplayInfo();

            Console.ReadLine();

        }
    }
}
