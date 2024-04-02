using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        class Person
        {
            public string Name;
            public int Age;


            //Non-Parameterized Constructor
            public Person()
            {
                Name = "Pothal";
                Age = 20;
            }
            
            // Parameterized Constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Ayush", 22);
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}");
            Console.ReadLine();
        }
    }
}
