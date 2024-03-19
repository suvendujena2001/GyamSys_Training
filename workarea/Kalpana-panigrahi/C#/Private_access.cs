
using System;
private class class1{
    private void show1(){
        Console.WriteLine("This is a public method");
    }
    private void show2(){
        class1 c1 = new class1();
        c1.show1();
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
       class1 c1= new class1();
       c1.show(); // this gives an error because it is private
       
    }
}