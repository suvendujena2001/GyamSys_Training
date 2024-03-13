using ClassLibraryNS;
using ClassLibraryNS.Add;
using ClassLibraryNS.Add.Test;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDotNet
{
    public class Animal
    {
        public static int NumberOfLegs;
    }

    public class Dog : Animal
    {
        static Dog()
        {
            NumberOfLegs = 4;
        }

        public void PrintNumberOfLegs()
        {
            Console.WriteLine($"A dog has {NumberOfLegs} legs.");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // int a = Dog.NumberOfLegs;
            
            
            Dog dog = new Dog();
            dog.PrintNumberOfLegs();


            ClassInternal classInternal = new ClassInternal();
            ClassAdd classAdd = new ClassAdd();
            ClassExample classExample = new ClassExample();



            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Id", typeof(int));
            dt1.Columns.Add("Name", typeof(string));
            dt1.Columns.Add("Age", typeof(int));

            DataRow dr = dt1.NewRow();
            dr["Id"] = 1;
            dr["Name"] = "Ajay";
            dr["Age"] = 27;
            dt1.Rows.Add(dr);

            DataTable dt2 = dt1.Clone();
            dr = dt2.NewRow();
            dr[0] = 2;
            dr[1] = "Ram";
            dr[2] = 29;
            dt2.Rows.Add(dr);

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dt1);
            dataSet.Tables.Add(dt2);

            //Employee employee = new Employee(10, "Suman", "Thummanapally") ;
            //Employee employee2 = new Employee(10, "Abcd", "Efgh");

            //Employee employee2 = new Employee();



            //int a = 10;
            //int b = a;
            //b = 20;


            //Employee employee = new Employee();
            //employee.EmpId = 10;
            //employee.FirstName = "Suman";
            //employee.LastName = "Thummanapally";

            //Employee employee2 = new Employee();

            //employee2 = employee;


            //employee.EmpId = 999;

            //string firstName = employee.GetFullName();            

            //try
            //{
            //    string a = "10";
            //    Convert.ToInt32(a);
            //    Console.WriteLine(a);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("Please enter valid number");
            //}

            //AddNumbers(10, 20, 23);

            //int sum = Class1.addNumbers(10, 30);
            //Console.WriteLine(sum);

            //AddTwoNumbers(b: "Test", a: 30);


            //string fullname =  FullName("Suman", "Thummanapally");
            //Console.WriteLine(fullname);

            //int[] arr = { 1, 2, 4, 5, 3, 9, 6 };

            //foreach (int i in arr)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //int index = 0;
            //do
            //{
            //    Console.WriteLine(arr[index]);
            //    index++;
            //}
            //while (index < arr.Length);



            //while (index < arr.Length)
            //{
            //    Console.WriteLine(arr[index]);
            //    index++;
            //}



            //int[] arr5 = { 1, 2, 4, 5, 3, 9, 6 };
            //int[] arr1 = new int[] { 1, 2, 4, 5, 3, 6, 9, 23, 7 };

            //string[] arr2 = { "Jan", "Feb", "Mar", "Apr" };
            //string[] arr3 = new string[] { "Jan", "Feb", "Mar", "Apr" };

            //int[] arr4 = new int[] { };
            //int d = arr4.Length;
            //Array.Copy(arr, arr4, 3);

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Abcd");
            //arrayList.Add(1);
            //arrayList.Add(DateTime.Now);
            //arrayList.Add(true);

            //string c = string.Empty;

            //int? b = null;
            //Console.WriteLine(b ?? 0);

            //bool? a = true;

            //Console.WriteLine(a ?? true);

            //Console.WriteLine((a.HasValue)? "Yes" : "No");

            //if (a.HasValue)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //Console.ReadLine();


            //string b = "Hellow";
            //Console.WriteLine(b);
            //Console.ReadLine();
        }

        private static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        private static void AddNumbers(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        private static void AddNumbers(double a, double b, double c)
        {
            Console.WriteLine(a + b + c);
        }


        public static string FullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
