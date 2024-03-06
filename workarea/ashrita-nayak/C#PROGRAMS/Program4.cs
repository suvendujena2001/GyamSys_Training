// See https://aka.ms/new-console-template for more information
using System;
class TypesExamples
{
    static void Main()
    {
         int msAgarwalAge = 24;
int mrSatpathyAge = msAgarwalAge;
Console.WriteLine("Ms. Agarwal age: {0}, Mr. Satpathy age: {1}",
            msAgarwalAge, mrSatpathyAge);
        mrSatpathyAge = 60;
        Console.WriteLine("Ms. Agarwal age: {0}, Mr. Satpathy age: {1}",
           msAgarwalAge, mrSatpathyAge);

        Person mrShankar = new Person();
 mrShankar.Age = 10;
 Person msStuti = mrShankar;
  Console.WriteLine("\nMr. Shankar age: {0}, Ms. Stuti age: {1}",
            mrShankar.Age, msStuti.Age);
 msStuti.Age = 91;
 Console.WriteLine("Mr. Shankar age: {0}, Ms. Stuti age: {1}",
            mrShankar.Age, msStuti.Age);
    }
}
public class Person
{
    public int Age;
}