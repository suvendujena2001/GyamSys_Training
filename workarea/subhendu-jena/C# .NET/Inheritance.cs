using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class baseClass
    {
        public virtual void funResult()
        {
            Console.WriteLine("Base Class");
        }
    }
    public class  derivedClass: baseClass
    {
        public void funWrite()
        {
            Console.WriteLine("Derived Class One");
        }

        public override void funResult()    //method overriding 
        {
            Console.WriteLine("Derived Class ONE");
        }
    }
    public class derivedClass2 : derivedClass 
    {
        public void funRead()
        {
            Console.WriteLine("Derived Class 2");
        }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {   
            baseClass bc= new baseClass();
            bc.funResult();

            //single inheritance
            derivedClass dc =new derivedClass();
            dc.funResult();
            dc.funWrite();

            //multi-level inheritance
            derivedClass2 dc2 = new derivedClass2();
            dc2.funResult();
            dc2.funWrite();
            dc2.funRead();

            derivedClass bdc= new derivedClass2(); //creating object of derivedClass using derivedClass2
            bdc.funWrite();
            bdc.funResult();

            Console.Read();
            //multiple inheritance
                

        }
    }
}
