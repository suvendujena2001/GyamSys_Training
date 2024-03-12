using System;
interface Bicycle
{
    void FirstMethod();
}
interface Scooty
{
    void SecondMethod();
}
class Road : Bicycle, Scooty
{
    public void FirstMethod()
    {
        Console.WriteLine("Do you have a bicycle to lend me?");
    }

    public void SecondMethod()
    {
        Console.WriteLine("Please take me on a " +
            "scooty ride around the village.");
    }
}

class Program
{
    static void Main()
    {
        Road myObj = new Road();
        myObj.FirstMethod(); 
        myObj.SecondMethod(); 
    }
}

