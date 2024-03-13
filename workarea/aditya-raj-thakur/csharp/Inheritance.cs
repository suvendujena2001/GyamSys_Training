using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    public class cars
    {
        public string name;
        public int year;
        public void Model()
        {
            Console.WriteLine("Honda");
        }
    }
    public class car1:cars    //Single Inheritance
    {  public void make()
        {
            Console.WriteLine("make name and year of the car is "  + name  +  year,"single inheritance");
            
        }
        public void Model()  // Method Overriding
        {
            base.Model(); // calling base class as well.
            Console.WriteLine("Hero");
        }

    }

    public class car2 : car1 // MULTI _LEVEL INHERITANCE
    {
        public void function1()
        {
            Console.WriteLine("brake,tyre-multilevel");
            
        }
    }
    public class car3 : cars
    {
        public void firstcar()
        {
            Console.WriteLine(" old -Hirerchical Inheritance");
        }
    }
    interface Category1 // MULTIPLE INHERITANCE
    {
        void Segment();
    }
    interface Category2
    {
        void Segment1();
    }
     public class car4 : Category1, Category2
    {
       public void Segment()
        {
            Console.WriteLine(" Category MULTIPLE INHERITANCE");
        }
        public void Segment1()
        {
            Console.WriteLine("Category1  Multiple Inheritance");
        }
        public int Segment2(int Length,int breadth)
        { 
           return Length * breadth;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car1 obj = new car1();
            car2 obj2 = new car2();
            car3 obj3 = new car3();
            car4 obj4 = new car4();
            obj.name = "alto";
            obj.year = 2005;
            obj.make();
            obj.Model(); // Method Overriding
            obj2.function1();
            obj3.firstcar();
            obj4.Segment1();
            obj4.Segment2(3,4);
            Console.Read();
           
        }
    }
}
