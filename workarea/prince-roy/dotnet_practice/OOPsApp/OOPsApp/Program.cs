// See https://aka.ms/new-console-template for more information
public class Human
{
    public string Name { get; set; }

    public string Id { get; set; }

    public Human(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Teacher : Human
{
    public Teacher(int id, string name)
    {
        base(id, name);
    }
}

public class Student: Human
{
    public Student(int id, string name)
    {
        base(id, name);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student s = new Student(101, "Prince Roy");
        Console.WriteLine(s);
    }
}