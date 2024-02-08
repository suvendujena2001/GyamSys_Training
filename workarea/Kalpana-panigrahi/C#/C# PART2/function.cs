using System;

public class HelloWorld
{
    static void Greet(string name)
    {
        Console.WriteLine("Good Morning"+name);
    }
    static int Avg(int a, int b, int c)
    {
        int sum = a + b+ c;
        return sum / 3;
    }
    static float Avg(int a, int b){
        return(a+b)/2;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        Greet("kp");
        Console.WriteLine(Avg(12,13,14));
        Console.WriteLine(Avg(12,13));//Methode overloding
        
    }
}