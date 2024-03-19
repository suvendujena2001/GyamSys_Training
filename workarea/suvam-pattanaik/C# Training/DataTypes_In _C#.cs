using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_
{
    internal class Program
    {
        static void Main(string[] args) { 
        
            /*value type:
             A variable in C# contains only its value and the variable name is directly associated with storage location in memory where it is stored.

            If we assign a value type to another value type variable , then exact value is copied but both the variables work independently.
            change in value of any variable doesnot affect the other variable.
            */

            int X = 600;
            int Y = 500;

            Console.WriteLine($"Value of X is :{X} ");
            Console.WriteLine($"Value of Y is : {Y}");

            X = Y;//Assign value of Y to X

            Y = 700;

            Console.WriteLine($"Value of X after reassign : {X}");
            Console.WriteLine($"Value of Y after reassign : {Y}");
            //Console.ReadLine();

            /*
             Reference Type :
            holds the reference of value 
            compiler allocates some memory space and store the values
            If we assign a reference type to another type variable then the reference is copied, both variables will point to same memory location.
            So any value change to one will change the other.

             
             */

            Employee emp = new Employee();
            emp.Name = "Suvam";
            emp.Age = 22;

            Employee emp2 = new Employee();
            emp2.Name = "Rahul";
            emp2.Age = 23;

            Console.WriteLine("Before assignment both emp and emp2 have different location");
            Console.WriteLine("emp.Name :" + emp.Name.ToString());
            Console.WriteLine("emp2.Name :" + emp2.Name.ToString());
            Console.WriteLine("///////////////////////////////////////////");

            emp2 = emp;

            Console.WriteLine("After assignment both emp and emp2 point to same location..");
            Console.WriteLine("emp.Name :" + emp.Name.ToString());
            Console.WriteLine("emp2.Name :" + emp2.Name.ToString());
            Console.WriteLine("///////////////////////////////////////////");

            emp2.Name = "Pattanaik";
            Console.WriteLine("Changed emp2 value that will affect emp also");
            Console.WriteLine("emp.Name :" + emp.Name.ToString());
            Console.WriteLine("emp2.Name :" + emp2.Name.ToString());
            Console.ReadLine();




        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

}
