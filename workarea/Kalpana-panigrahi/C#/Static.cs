using System;
class university{
    private static string UniversityName;
    //private static string DepartmentName;
    
    public static string _UniversityName
    {
        set{
            UniversityName = value;
        }
        get{
            return UniversityName;
        }
    }
    
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        university._UniversityName = "kalpana";
        Console.WriteLine(university._UniversityName);
        
    }
}