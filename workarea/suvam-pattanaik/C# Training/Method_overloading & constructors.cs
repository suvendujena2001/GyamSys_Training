using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OverLoading
{
 

   
    internal class Program
    {

        public int Add(int a , int b , int c)
        {
            int sum = a + b + c;
            return sum;
        }

        public double Add(double a , double b , double c)
        {
            double sum = a + b + c;
            return sum;
        }


        int num;
        String name;

        

        Program(int num, String name)
        {
            this.num = num;
            this.name = name;
        }
        Program()
        {
            Console.WriteLine("Constructor Called");
        }

        static void Main(string[] args)
        {
            Program pg = new Program();

            //int sum2 = pg.Add(1, 2, 3);
            //Console.WriteLine("Sum is " +sum2);

            //double sum3 = pg.Add(1.0, 2.0, 3.0);
            //Console.WriteLine("SUM is " + sum3);

          

           //Program pg2 = new Program();
           // Console.WriteLine(pg2.name);
            //Console.WriteLine(pg2.num);

            Program pg3 = new Program(1,"Suvam");
            Console.WriteLine(pg3.name);
            Console.WriteLine(pg3.num);

            Console.Read();


        }
    }
}
