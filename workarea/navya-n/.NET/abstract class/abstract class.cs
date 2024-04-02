using system;
public abstract class Animal
{
    public abstract void Numoflegs();
    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping...");
    }
}
public class Dog : Animal
{
    public override void Numoflegs()
    {
        Console.WriteLine("The dog has 4 legs!!");
    }
}

public class Program
{
    public static void Main()
    {
        Dog myDog = new Dog();
        myDog.Numoflegs();
        myDog.Sleep();
    }
}
