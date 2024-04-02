// lambda function is used for simplify the Anonymous function
using System;
public delegate void myDeligate(int num);
public class HelloWorld
{
    public static void Main(string[] args)
    {
       myDeligate obj = (a) =>
       {
            a += 10;
             Console.WriteLine (a);
            
        };
        obj(23);
    }
}