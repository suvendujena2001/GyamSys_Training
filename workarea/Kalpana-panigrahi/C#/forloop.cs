using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        
        for(int i=0;i<5;i++){
            if(i==0){
               continue; 
            }
            
            Console.WriteLine(i+1);
            //break- leave this loop forever
        }
        //break and continue
        
        
        Console.ReadLine();
    }
}