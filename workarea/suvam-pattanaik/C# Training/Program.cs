using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Program
    {
        static void Main(string[] args)
            
        {
        Console.WriteLine("Hello World");
        Console.Read();

        
        //creating variables:

        // string 

        String name = "Suvam";
        Console.WriteLine(name);
        Console.WriteLine("Hello " + name);

        // int
        int mynum = 7;
        Console.WriteLine(mynum);


        double mydouble = 5.90D;
        char letter = 'A';
        bool mybool = false;*/


        //type casting 
        /* Implicit : smaller to larger type size
         char -> int ->long->float->double

        Explicit  : larger to smaller type size

        double -> float ->long->int ->char
         
         */
        
        int myint = 9;
        double myDouble = myint;

        Console.WriteLine(myint);
        Console.WriteLine(myDouble);


        double Double = 9.78;
        int Int = (int)Double;

        Console.WriteLine(Double);
        Console.WriteLine(Int);

        //Console.ReadLine method returns a string .

        Console.WriteLine("Enter Your Age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your age is : " + age);


        // String Operation

        string greeting1 = "Hello World";
        Console.WriteLine("The length is :" + greeting1.length);

        Console.WriteLine(greeting1.ToUpper());
        */
        // String concatenation 

        string firstName = "Suvam";
        string lastName = "Pattanaik";

        string name = firstName + lastName;
        Console.WriteLine(name);
        Console.ReadLine();

        string name2 = $"My name is :{ firstName}
        {  lastName }";
            Console.WriteLine(name2);




        }
    }

