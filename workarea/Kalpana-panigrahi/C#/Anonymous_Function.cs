using System;
public delegate void myDeligate(int a);
public class HelloWorld
{
    public static void Main(string[] args)
    {
        myDeligate obj = delegate (int a){
            a += 10;
             Console.WriteLine (a);
            
        };
        obj(23);
       
    }
}