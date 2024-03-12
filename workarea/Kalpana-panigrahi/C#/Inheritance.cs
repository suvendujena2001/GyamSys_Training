using System;

// Single Inheritance
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Multiple Inheritance 
interface IWalkable
{
    void Walk();
}

interface IFlyable
{
    void Fly();
}

class Bird : IWalkable, IFlyable
{
    public void Walk()
    {
        Console.WriteLine("Bird is walking...");
    }

    public void Fly()
    {
        Console.WriteLine("Bird is flying...");
    }
}

// Multilevel Inheritance
class Animal2
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

class Dog2 : Animal2
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking...");
    }
}

class Labrador : Dog2
{
    public void Retrieve()
    {
        Console.WriteLine("Labrador is retrieving");
    }
}

// Hybrid Inheritance (using interfaces and classes)
interface IMoveable
{
    void Move();
}

class Vehicle : IMoveable
{
    public void Move()
    {
        Console.WriteLine("Vehicle is moving");
    }
}

class Car : Vehicle
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }
}

class FlyingCar : Car, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Flying car is flying");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Single Inheritance
        Dog dog = new Dog();
        dog.Eat(); // Output: Animal is eating...
        dog.Bark(); // Output: Dog is barking...

        Console.WriteLine();

        // Multiple Inheritance (via interfaces)
        Bird bird = new Bird();
        bird.Walk(); // Output: Bird is walking...
        bird.Fly(); // Output: Bird is flying...

        Console.WriteLine();

        // Multilevel Inheritance
        Labrador labrador = new Labrador();
        labrador.Eat(); // Output: Animal is eating...
        labrador.Bark(); // Output: Dog is barking...
        labrador.Retrieve(); // Output: Labrador is retrieving...

        Console.WriteLine();

        // Hybrid Inheritance (using interfaces and classes)
        FlyingCar flyingCar = new FlyingCar();
        flyingCar.Move(); // Output: Vehicle is moving...
        flyingCar.Start(); // Output: Car started...
        flyingCar.Fly(); // Output: Flying car is flying...
    }
}
