using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data types in C#
            int a = 23;
            bool b = true;
            char c = 'c';
            double d = 34.65;
            decimal dm = 34.746m;
            long l = 23567654;
            short si = 32;
            string s = "hello";
            Console.WriteLine("integer: "+a+"\n"+"boolean: "+b+"\n"+"character: "+c+"\n"+"double: "+d+"\n"+"decimal: "+dm+"\n"+"long: "+l+"\n"+"short: "+si+"\n"+"string: "+s+"\n");
            Console.WriteLine("integer min value: " + int.MinValue + "\n" + "integer max value: " + int.MaxValue + "\n");
            Console.WriteLine("decimal min value: " + decimal.MinValue + "\n" + "decimal max value: " + decimal.MaxValue + "\n");
            Console.WriteLine("double min value: " + double.MinValue + "\n" + "double max value: " + double.MaxValue + "\n");
            Console.WriteLine("short int min value: " + short.MinValue + "\n" + "short int max value: " + short.MaxValue + "\n");
            Console.WriteLine("long int min value: " + long.MinValue + "\n" + "long int max value: " + long.MaxValue + "\n");

            //TYPECASTING IN C#
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            string myString = "832";

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            Console.WriteLine(Convert.ToInt32(myString));  // convert string to int

            //Concatanation
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string x = "10";
            string y = "20";
            string z = x + y;
            Console.WriteLine(z);

            //Arithmetic Operators
            int m = 50;
            int n = 5;
            Console.WriteLine($"Addition of {m} and {n}: "+(m+n)); //Addition
            Console.WriteLine($"Subtraction of {m} and {n}: " + (m - n)); //Subtraction
            Console.WriteLine($"Multiplication of {m} and {n}: " + (m * n)); //Multiplication
            Console.WriteLine($"Division of {m} and {n}: " + (m / n)); //Division
            Console.WriteLine($"Modulus of {m} and {n}: " + (m % n)); //Modulus
            Console.WriteLine($"Increment of {m}: " + (++m)); //Increment
            Console.WriteLine($"Decrement of {n}: "+ (--n)); //Decrement

            //IF-ElSE Condition

            if (m > n)
            {
                Console.WriteLine($"{m} is greater than {n}");
            }
            else if(m==n)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine($"{n} is greater than {m}");
            }

            // Switch case
            Console.WriteLine("Enter a number: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: 
                    Console.WriteLine("Wrong input(Input should be between 1 to 7)");
                    break;
            }

            //LOOPS

            // While loop
            int i = 0;
            while (i < 5)
            {
                Console.Write(i+" ");
                i++;
            }

            //do While loop
            Console.WriteLine("\n");
            do
            {
                Console.Write(i+" "+"(As i = 5 so it will run atleast one time then exit.)");
                i++;
            }
            while (i < 5);
            Console.WriteLine("\n");

            //FOR Loop
            for (int f = 0; f <= 10; f = f + 2)
            {
                Console.Write(f+" ");
            }
            Console.WriteLine("\n");

            //Nested For Loop
            for (int ol = 1; ol <= 2; ++ol) //outer loop
            {
                Console.WriteLine("Outer loop: " + ol);  // Executes 2 times
                for (int il = 1; il <= 3; il++) //inner loop
                {
                    Console.WriteLine(" Inner loop: " + il); // Executes 6 times (2 * 3)
                }
            }
            Console.WriteLine("\n");

            //ForEach loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string ars in cars)
            {
                Console.Write(ars+" ");
            }
            Console.WriteLine("\n");

            //BREAK and CONTINUE in C#
            //break in for loop
            for (int br = 0; br < 10; br++)
            {
                if (br == 4)
                {
                    break; // stop execution at the value of 4
                }
                Console.Write(br+" ");
            }
            Console.WriteLine("\n");

            //continue in while loop
            int cn = 0;
            while (cn < 10)
            {
                if (cn == 4)
                {
                    cn++;
                    continue;  // skipping 4
                }
                Console.Write(cn+" ");
                cn++;
            }
            Console.WriteLine("\n");


            //Array in C#
            //1D array
            string[] arr = { "abc", "bcd", "efg" };
            foreach(string item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n");

            //2D Array
            int[,] arr_2d = { { 2, 4, 3 }, { 6, 4, 7 }, { 6, 3, 7 } };
            for(int i2=0;i2<arr_2d.GetLength(0);i2++)
            {
                for(int j2=0;j2<arr_2d.GetLength(1);j2++)
                {
                    Console.Write(arr_2d[i2,j2]+" ");
                }
                Console.WriteLine("\n");
            }

            //Jagged Arrays -- array of arrays

            int[][] jagged_arr = { new int[] { 1, 2, 3, 4 }, new int[] { 11, 34, 67 }, new int[] { 89, 23 }, new int[] { 0, 45, 78, 53, 99 } };
            for (int ja = 0; ja < jagged_arr.Length; ja++)
            {
                System.Console.Write($"Row({ja}): Elements of array {ja+1}: ");

                for (int jk = 0; jk < jagged_arr[ja].Length; jk++)
                {
                    System.Console.Write($"{jagged_arr[ja][jk]} ");
                }
                System.Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
