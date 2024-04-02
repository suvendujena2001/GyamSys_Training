using System;


public class class1{
    internal void show1(){
         Console.WriteLine ("This is a protected method");
    }
    public void show2(){
        class1 c1 = new class1();
        c1.show1();
    }// it is accessble with in the current class
}
public class HelloWorld 
{

    public static void Main(string[] args)
    {
        
        class1 c1 = new class1(); 
        c1.show1();
    
        Console.ReadLine ();
    }
}