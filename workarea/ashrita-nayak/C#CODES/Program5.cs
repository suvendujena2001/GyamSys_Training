// See https://aka.ms/new-console-template for more information
using System;
namespace ImpliExpli
{
    class winter9
    {
        static void Main(string[] args)
        {
            //implicit conversion example
            int numInt = 671;
            Type n = numInt.GetType();
            double numDouble = numInt;
            Type n1 = numDouble.GetType();
            Console.WriteLine("numInt value: " + numInt);
            Console.WriteLine("numInt Type: " + n);
            Console.WriteLine("numDouble value: " + numDouble);
            Console.WriteLine("numDouble Type: " + n1);
            double numfloat = 90.76;
            int numInteger = (int)numfloat;
            Console.WriteLine("Original float Value: " + numfloat);
            Console.WriteLine("Converted int Value: " + numInteger);
        }
    }
        
           
    
       
    }



