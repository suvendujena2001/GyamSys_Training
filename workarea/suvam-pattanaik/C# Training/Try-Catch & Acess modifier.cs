using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Block
{
 
    class Student
    {
        public int rollNo;
        public String name;

        public Student(int r , String n)
        {
            rollNo = r;
            name = n;
        }

        public int getRollNo()
        {
            return rollNo;
        }
        public String getName()
        {
            return name;
        }
    }

    class X
    {
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    class Y : X
    {
        public int getX()
        {
            return x;
        }
    }

    internal class Complex
    {
        int real;
        int img;

        public void setData(int r , int i)
        {
            real = r;
            img = i;
        }
        public void displayData()
        {
            Console.WriteLine("Real : " + real);
            Console.WriteLine("Imaginary : " + img);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 19, 0, 75, 52 };
            try
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i+1]);
                }
            }
            catch(IndexOutOfRangeException e) {
            Console.WriteLine( " An exception has occured :"+ e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("An exception has occured :" + e.Message);
            }
            catch (ArgumentOutOfRangeException e) {
            Console.WriteLine("An exception occured :"+e.Message);
            }

            finally
            {
                for(int i=0;i< arr.Length; i++)
                {
                    Console.Write(" " + arr[i]);
                }
            }

            Console.WriteLine();

            // public access modifier

            Student S = new Student(1, "Suvam");
            Console.WriteLine("Roll no is:" + S.rollNo);
            Console.WriteLine("Name is :" + S.name);

            Console.WriteLine();

            // protected access modifier

            X obj1 = new X();
            Y obj2 = new Y();

            Console.WriteLine("Value of x is :" + obj2.getX());

            Console.WriteLine();

            // internal modifier

            Complex c = new Complex();
            c.setData(2, 1);
            c.displayData();





        }
    }
}
