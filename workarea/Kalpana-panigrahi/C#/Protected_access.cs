
using System;


public class class1{
    protected void show1(){
         Console.WriteLine ("This is a protected method");
    }
    public void show2(){
        class1 c1 = new class1();
        c1.show1();
    }// it is accessble with in the current class
}
public class HelloWorld : class1
{

    public static void Main(string[] args)
    {
        HelloWorld h1 = new HelloWorld();
        //class1 c1 = new class1(); ////inaccessible due to its protection level
        
        h1.show1(); 
        Console.ReadLine ();
    }
}