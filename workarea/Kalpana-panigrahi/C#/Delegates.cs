using System;
public delegate void claculation(int a, int b);
public class HelloWorld
{
    public static void Addition(int a, int b){
        int result = a+b;
        Console.WriteLine (result);
        
    }
    public static void Main(string[] args)
    {
        claculation obj = new  claculation(HelloWorld.Addition);
       obj.Invoke(29,76);
    }
}