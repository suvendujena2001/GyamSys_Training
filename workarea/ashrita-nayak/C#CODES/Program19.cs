using System;
public class AccessModifiersExample
{
    public int publicField = 340;
    private int privateField = 812;
    protected int protectedField = 946;
    internal int internalField = 1270;
    public void PublicMethod()
    {
        Console.WriteLine("Public method");
    }
    private void PrivateMethod()
    {
        Console.WriteLine("Private method");
    }
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method");
    }
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method");
    }
}
public class DerivedClass : AccessModifiersExample
{
    public void AccessProtectedField()
    {
        Console.WriteLine("Protected Field " +
            "from Derived Class: " + protectedField);
    }
}

class Program
{
    static void Main(string[] args)
    {
        AccessModifiersExample example = new AccessModifiersExample();
        Console.WriteLine("Public Field: " + example.publicField);
        Console.WriteLine("Internal Field: " + example.internalField);
        example.PublicMethod();
        example.InternalMethod();
        DerivedClass derivedObj = new DerivedClass();
        derivedObj.AccessProtectedField();
    }
}
