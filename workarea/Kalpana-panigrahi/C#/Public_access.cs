using System;

public class class1{
    public void show1(){
        Console.WriteLine("This is a public method");
    }
    public void show2(){
        class1 c1 = new class1();
        c1.show1();
    }
}

public class HelloWorld : class1
{
    public static void Main(string[] args)
    {
        class1 c1 = new class1();
        c1.show1();
        c1.show2();
        HelloWorld h1 = new HelloWorld();
        h1.show1();
    }
}