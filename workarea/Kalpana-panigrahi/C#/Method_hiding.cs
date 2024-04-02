using System;

public class HelloWorld
{
    class parent{
        public void show(){
            Console.WriteLine("Parent class method");
        }
        
    }
    class child : parent
    {
         public new void show() // new shows that child class hide the method of parent class
        {
            Console.WriteLine("Child class method");
        }
    }
    public static void Main(string[] args)
    {
        child c = new child();
        c.show() // Here child class method hide the parent class method
        Console.WriteLine ("");
    }
}