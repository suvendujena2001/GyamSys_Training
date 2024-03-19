using System;
class parent
{
    virtual void print(){
    Console.WriteLine("Parent method");
}
  
class child: parent
{
      override void print(){
  Console.WriteLine("Child method");
}
  
class program
{
  public static void Main(string[] args)
  {
    parent par = new child;
    par.print();
    child chl = new child;
    chl.print();
    Console.ReadLine();
  }
}
