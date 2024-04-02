using System;

class student{
    private int stdid;
    private string _Name;
    public int StdId{
        set{
            if (value <= 0){
                Console.WriteLine("Id can not be 0 or negative");
            }
            else{
                this.stdid = value;
            }
            
        }
        get{
            return this.stdid;
        }
    }
    public string Name{
        set{
            if (string.IsNullOrEmpty(value)){
                Console.WriteLine("Please enter your name");
            }
            else{
                this._Name = value;
            }
            
        }
        get{
            return this._Name;
        }
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        student s = new student();
        s.StdId = 20;
        s.Name = "Kalpana";
        
        Console.WriteLine(s.StdId);
        Console.WriteLine(s.Name);
    }
}