using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IDrawable
{
    void draw();
}
public class Rectangle : IDrawable
{
    public void draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}
public class Circle : IDrawable
{
    public void draw()
    {
        Console.WriteLine("Drawing Circle");
        Console.ReadLine();
    }
}
public class Test
{
    public static void Main()
    {
        IDrawable d;
        d = new Rectangle();
        d.draw();
        d = new Circle();
        d.draw();
    }
}