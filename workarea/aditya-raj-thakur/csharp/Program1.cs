using System;
using System.Collections;

namespace Program1Namespace
{


    public class Program1
    {
        public static void AddNumbers(int a, int b)
        { /// MEthod Overloading
            Console.WriteLine(a + b);
        }
        public static void AddNumbers(doube a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void AddNumbers(doube a, double b, double c)
        {
            Console.WriteLine(a + b + c);
        }
        void DisplayTimes()
        {
            // Insert Function
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }
            Console.WriteLine();
        }

        void AdjustTimes()
        {
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = ((times[i] + diff)) % 2400;
            }
        }

        public static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Array.Sort(pallets); // SORT

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            AddNumbers(1, 2);
            try  // try -catch
            {
                string a = "hello";
                Convert.ToInt32(a);
                Console.WriteLine(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Enter Valid Number");


            }


            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";
            // Try Parse

            foreach (var value in values)
            {
                decimal number; // stores the TryParse "out" value
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");



            // Index Of
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length)); 



            int[] times = { 800, 1200, 1600, 2000 };
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Current Medicine Schedule:");
            DisplayTimes();

            Console.WriteLine("Enter new GMT");
            int newGMT = Convert.ToInt32(Console.ReadLine());
            // Math library
            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                AdjustTimes();
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                AdjustTimes();
            }

            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes();

            

           





        }
    }
}
