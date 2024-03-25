using System;
abstract class person
{
     public string Name;
     public int age;
     public long PhoneNumber;
     
     public abstract void PrintDetails();
}
class student : person {
    public int rollNo;
    public int fees;
     public override void PrintDetails(){
         string Name = this.Name;
         Console.WriteLine(Name);
         Console.WriteLine(this.age);
         Console.WriteLine(this.PhoneNumber);
         Console.WriteLine(this.fees);
         Console.WriteLine(this.rollNo);
         
     }
}
class teacher : person {
    public string qualification;
    public int salary;
     public override void PrintDetails(){
          string Name = this.Name;
         Console.WriteLine(Name);
         Console.WriteLine(this.age);
         Console.WriteLine(this.PhoneNumber);
         Console.WriteLine(this.qualification);
         Console.WriteLine(this.salary);
     }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        student kp = new student();
        kp.Name = "Kalpana";
        kp.age = 21;
        kp.PhoneNumber = 1234567;
        kp.fees = 4300;
        kp.rollNo = 01;
        kp.PrintDetails();
        teacher ABC = new teacher();
        ABC.Name = "ABCDE";
        ABC.age = 34;
        ABC.PhoneNumber = 99999999;
        ABC.qualification = "Btech";
        ABC.salary = 23400;
        ABC.PrintDetails();
    }
}