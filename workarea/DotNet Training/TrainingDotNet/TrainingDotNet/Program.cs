using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = Class1.addNumbers(10, 30);
            Console.WriteLine(sum);



            AddTwoNumbers(b: "Test", a: 30);


            string fullname =  FullName("Suman", "Thummanapally");
            Console.WriteLine(fullname);

            int[] arr = { 1, 2, 4, 5, 3, 9, 6 };

            foreach (int i in arr)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int index = 0;
            do
            {
                Console.WriteLine(arr[index]);
                index++;
            }
            while (index < arr.Length);


            
            while (index < arr.Length)
            {
                Console.WriteLine(arr[index]);
                index++;
            }



            int[] arr5 = { 1, 2, 4, 5, 3, 9, 6 };
            int[] arr1 = new int[] { 1, 2, 4, 5, 3, 6, 9, 23, 7 };

            string[] arr2 = { "Jan", "Feb", "Mar", "Apr" };
            string[] arr3 = new string[] { "Jan", "Feb", "Mar", "Apr" };

            int[] arr4 = new int[] { };
            int d = arr4.Length;
            Array.Copy(arr, arr4, 3);

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Abcd");
            arrayList.Add(1);
            arrayList.Add(DateTime.Now);
            arrayList.Add(true);

            string c = string.Empty;

            int? b = null;
            Console.WriteLine(b ?? 0);

            bool? a = true;

            Console.WriteLine(a ?? true);

            Console.WriteLine((a.HasValue)? "Yes" : "No");

            if (a.HasValue)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();


            //string b = "Hellow";
            //Console.WriteLine(b);
            //Console.ReadLine();
        }

        private static void AddTwoNumbers(int a, string b)
        {
            Console.WriteLine(b);
        }

        public static string FullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
