using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
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


            //******* C# Assignment:*********

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

            int[][] jagged_arr = { new int[] { 3, 1, 9, 32 },
                                   new int[] { 91, 4, 73 }, 
                                   new int[] { 62, 2223 }, 
                                   new int[] { 0, 6345, 378, 6753, 9999 },
                                   new int[] { 69,638,3737},
                                   new int[] { 647}
                                 };
            for (int ja = 0; ja < jagged_arr.Length; ja++)
            {
                System.Console.Write($"Row({ja}): Elements of array {ja+1}: ");

                for (int jk = 0; jk < jagged_arr[ja].Length; jk++)
                {
                    System.Console.Write($"{jagged_arr[ja][jk]} ");
                }
                System.Console.WriteLine("\n");
            }

            //Param Object array
            Obj_param_Array obj = new Obj_param_Array();
            obj.result("param", "array",
                       "param object array",
                            "array", "999");

            Console.WriteLine("\n");

            //Param Integer Array
            int Additon(params int[] Numbers)
            {
                int total = 0;
                foreach (int pi in Numbers)
                {
                    total += pi;
                }
                return total;
            }
            int sum = Additon(3, 5, 2, 1, 4, 5, 2, 1);
            Console.WriteLine(sum);

            // Array List

            ArrayList myList = new ArrayList();

            // Adding elements to ArrayList 
            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Add(10);
            myList.Add(12);
            myList.Add(14);
            myList.Add(16);
            myList.Add(18);
            myList.Add(20);

            Console.WriteLine("The initial ArrayList: ");

            foreach (int ali in myList)
            {
                Console.Write(ali+" ");
            }
            Console.WriteLine("\n");
            // removing 4 elements starting from index 0 --- syntax- RemoveRange(strting_position, number_of_elements_to_be_removed); 
            myList.RemoveRange(3,3);

            Console.WriteLine("The ArrayList after Removing elements: ");

            foreach (int mli in myList)
            {
                Console.Write(mli+" ");
            }
            Console.WriteLine("\n");

            //Hashtables
            Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Keys)
            {
                Console.WriteLine($"{ele2} and {my_hashtable2[ele2]}");
            }

            Console.WriteLine($"Third key value of the hashtable: {my_hashtable2[3]}");   // Accessing the hashtable for key=3
            Console.WriteLine("\n");

            //Sorted List
            SortedList my_list = new SortedList() {
                                  { "2.09", 234 },
                                  { "6.21", 395 },
                                  { "6.31", 405 },
                                  { "5.67", 100 },
                                  { "2", 454 }};

            foreach (DictionaryEntry pair in my_list)
            {
                Console.WriteLine($"{pair.Key} and {pair.Value}");
            }
            Console.WriteLine("\n");

            //Stack in C#
            Stack my_stack = new Stack();
            my_stack.Push("Implentation of");
            my_stack.Push("Stack");
            my_stack.Push("In C#");
            my_stack.Push(1234);
            my_stack.Push(99999);

            my_stack.Pop();
            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("\n");
            //Queue in C#
            Queue my_queue = new Queue();
            my_queue.Enqueue("Hi");
            my_queue.Enqueue("Hello!!");
            my_queue.Enqueue("I am");
            my_queue.Enqueue("Soumyadip");
            my_queue.Enqueue("My Intern ID");
            my_queue.Enqueue(2152);

            my_queue.Dequeue();
            foreach(var q in my_queue)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("\n");

            //Bit Array in C#
            BitArray my_bitarray = new BitArray(3,true); // 3 bits are set to true
            BitArray my_bitarray2 = new BitArray(4); // 4 bits are set to false
            Console.WriteLine("3 bits initialize with true: \n");
            foreach (var tba in my_bitarray)
            {
                Console.WriteLine(tba);
            }
            Console.WriteLine("4 bits initialize with false: \n");
            foreach (var fba in my_bitarray2)
            {
                Console.WriteLine(fba);
            }


            Console.ReadLine();
        }
    }

    class Obj_param_Array
    {  
        public void result(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            { 
                Console.WriteLine(arr[i]);
            }
        }

    }
}
