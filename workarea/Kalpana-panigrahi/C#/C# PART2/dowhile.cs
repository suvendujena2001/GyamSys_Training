using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        
        //Loops in c#
        /*while loop
        int i=0;
        while(i<5){
            Console.WriteLine(i);
            i++;
            */
        //Do While loop
        int i=0;
        do{
            Console.WritrLine(i+1);
            i++;
        } while(i>5);
    }
}