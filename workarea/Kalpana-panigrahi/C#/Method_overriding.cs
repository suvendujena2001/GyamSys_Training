using System;

public class HelloWorld
{
     class parent{
        public virtual void print(){
            Console.WriteLine("Parent class method");
        }
        
    }
    class child : parent
    {
         public override void print() 
        {
            Console.WriteLine("Child class method");
        }
    }
    public static void Main(string[] args)
    {
        parent p = new child();
        p.print();
       
    }
}