using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverriding
{ 
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public  virtual void Work()
        {
            Console.WriteLine("It works..");
        }
    }
    class Student : Person
    {
        public override void Work()
        {
            Console.WriteLine("It studies..");
        }
    }
    class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public override void Work()
        { 
            Console.WriteLine("It earns..");
        }
    }
    class Manager : Employee
    {
        public sealed override void Work()
        {
            Console.WriteLine("It manages a team..");
            Console.ReadLine();
        }
    }
    class BranchManager : Manager
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student();
            p1.Work();
            p1 = new Employee();
            p1.Work();
            p1 = new Manager();
            p1.Work();
        }
    } 
}

