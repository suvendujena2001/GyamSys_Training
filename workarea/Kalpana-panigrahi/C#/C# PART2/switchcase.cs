public class HelloWorld
{
    public static void Main(string[] args)
    {
     
        int age = 78;
        switch(age){
            case 18:
            Console.WriteLine("Please Wait for an year");
            break;
            case 20:
            Console.WriteLine("You are 20");
            break;
            default:
            Console.WriteLine("Please Wait for an year");
            break;
        }
        Console.ReadLine();
    }
}