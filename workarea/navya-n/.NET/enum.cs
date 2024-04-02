using system;
class compute
{
  enum shape
  {
    square,
    circle
  }
  public void area(int val,shape s)
  {
    if(s1==0)
    {
      Console.WriteLine("The area of square is" + val*val);
    }
    else
    {
      Console.WriteLine("The area of circle is" + 3.14*val*val);
    }
  }
}

class program
{
  public static void main(string[] args)
  {
    compute obj=new compute();
    obj.area(5,compute.shape.square);
    obj.area(9,compute.shape.circle);
  }
}
