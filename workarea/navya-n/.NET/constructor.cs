using system;
class MyClass
{
    private int val;
    public MyClass(int value)                         //constructor
    {
        val = value;
        Console.WriteLine("Constructor called.");
    }
  
    ~MyClass()                                        //destructor
    {
        Console.WriteLine("Destructor called.");
    }
  
    public void PrintValue()
    {
        Console.WriteLine("The value is: " + val);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass(42);
        obj.PrintValue();
        Console.ReadLine();
    }
}
