
using System;


class Person {
    private string Name;
    private int Age;
    public void setName(string Name){
        if(string.IsNullOrEmpty(Name)==true){
           Console.WriteLine("Name is Required") ;
        }
        else{
            this.Name = Name;
        }
        
    }
    public void getName(){
        if(string.IsNullOrEmpty(Name)==true){
           Console.WriteLine("Name is Required") ;
        }else{
           Console.WriteLine("Your name is:" + this.Name); 
        }
        
        
    }
     public void setAge(int Age){
        if (Age>0){
             this.Age = Age;
        }
        else{
            Console.WriteLine("Age should not be negative or 0") ;
        }
       
    }
    public void getAge(){
        Console.WriteLine("Your Age is:" + this.Age);
    }
    
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.setName("Kalpana");
        p1.getName();
        p1.setAge(21);
        p1.getAge();
    }
}