using System;

class HelloWorld
{
    public static void Add(){
        int a=10;
        int b=50;
        int c = a+b;
        Console.WriteLine(c);
    }
    public static void Add(int a, int b){
        int c = a+b;
        Console.WriteLine(c);
        
    }
    public static void Add(int a, int b,int c){
        int d = a+b+c;
        Console.WriteLine(d);
        
    }
    
    public static void Main(string[] args)
    {
        Add();
        Add(23,45);
        Add(1,2,3);
    }
}