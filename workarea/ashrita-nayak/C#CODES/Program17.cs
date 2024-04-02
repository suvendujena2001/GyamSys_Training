using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of Dog
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Sleep();
        myDog.Bark();
    }
}

