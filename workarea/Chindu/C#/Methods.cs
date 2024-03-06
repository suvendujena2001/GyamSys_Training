/*In C#, methods are blocks of code that perform a specific task and are typically associated with a class. 
  They allow us to organize your code into reusable units and make it more readable and maintainable.*/

// Method with return type and parameters
public int Add(int a, int b)
{
    return a + b;
}

// Method without return type and parameters
public void PrintMessage()
{
    Console.WriteLine("Hello, World!");
}

//Access Modifiers:
//Access modifiers control the accessibility of methods. The common access modifiers are public, private, protected, internal, and protected internal.

public void PublicMethod()
{
    // Accessible from anywhere
}

private void PrivateMethod()
{
    // Accessible only within the same class
}
//Return Type:
//Methods can have a return type, which specifies the type of value returned by the method. If the method does not return any value, the return type is void.

