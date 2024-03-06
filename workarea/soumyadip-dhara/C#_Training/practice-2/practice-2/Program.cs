using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method Overloading
            int res = sum(3, 7, 8);
            Console.WriteLine(res);
            double res1 = sum(4, 8.4, 30);
            Console.WriteLine(res1);
            int res2 = sum(5, 3);
            Console.WriteLine(res2);
            double res3 = sum(6.7, 3.2);
            Console.WriteLine(res3);

            string s = Console.ReadLine();
            int[] arr = { 5, 4, 2, 5 };
            try
            {
                int n = Convert.ToInt32(s);
                Console.WriteLine(s);
                Console.WriteLine(arr[4]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("enter a number");
                string a = Console.ReadLine();
                int n = Convert.ToInt32(a);
                Console.WriteLine(a);
            }
            finally
            {
            }


            try
            {
                class1 cl = new class1();
                Console.WriteLine(cl.getsubtraction());
                // Console.WriteLine(cl.p);
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }


            //Properties in C#
            Student st = new Student();
            st.Name = "Gyansys";
            Console.WriteLine(st.Name);

            //Class and Objects
            Dog dg = new Dog("rocky", "papillon", 5, "white");
            Console.WriteLine(dg.ToString());

            //Constructor and Destructor
            Welcome obj = new Welcome();

            // Creating object for welcome class by passing parameter
            // This will called parametarized constructor which matches
            Welcome pObj = new Welcome("Soumyadip Dhara");

            Console.ReadLine();
        }




        public static int sum(int x, int y, int z)
        {
            return (x + y + z);
        }

        public static double sum(int a, double b, double c)
        {
            return (a + b + c);
        }

        public static int sum(int a, int b)
        {
            return (a + b);
        }

        public static double sum(double a, double b)
        {
            return (a + b);
        }

    }

    public class class1
    {
        private int p = 64;
        protected int q = 43;
        public int getsubtraction()
        {
            return p - q;
        }
    }

    public class Student
    {

        // Declare name field
        private string name = "Microsoft practice";

        // Declare name property
        public string Name
        {

            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }

    public class Dog
    {

        // Instance Variables
        String name;
        String breed;
        int age;
        String color;

        // Constructor Declaration of Class
        public Dog(String name, String breed,
                      int age, String color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        // Property 1
        public String GetName()
        {
            return name;
        }

        // Property 2
        public String GetBreed()
        {
            return breed;
        }

        // Property 3
        public int GetAge()
        {
            return age;
        }

        // Property 4
        public String GetColor()
        {
            return color;
        }

        // Method 1
        public String ToString()
        {
            return ("Hi my dog name is " + this.GetName()
                    + ".\nHis breed, age and color are " + this.GetBreed()
                    + ", " + this.GetAge() + ", " + this.GetColor());
        }
    }

    //Constructor and destructor
    class Welcome
    {
        // Default constructor
        public Welcome()
        {
            Console.WriteLine("Welcome message from Default Constructor.");
        }

        // Parametarized constructor
        public Welcome(string name)
        {
            Console.WriteLine("\n\nThis message from parametarized constructor");
            Console.WriteLine($"Welcome to Constructor sample, by {name}");
        }

        ~Welcome()
        {
            Console.WriteLine("Destructor called");
        }
    }
}
