using System;
namespace MyApp1
{
   public class AccessSpecifierClass1
    {
        private int Id=101;
        public string name="Anand";
        protected int age=21;
        public void Display1()
        {
            //Private Member Accessible with the Containing Type only
            //Where they are created, they are available only within that type
            Console.WriteLine(Id);
            //Public Members Accessible with the Containing Type
            //Where they are created
             Console.WriteLine(name);
             //protected Members Accessible with the Containing Type 
            //Where they are created
            Console.WriteLine(age);
        }
    }
    public class AccessSpecifierClass2 : AccessSpecifierClass1
    {
        public void Display2()
        {
            //You cannot access the Private Member from the Derived Class
            //Within the Same Assembly
            //Console.WriteLine(Id); //Compile Time Error
            //We Can access public Members from Derived Class
            //Within the Same Assembly
            Console.WriteLine(name);
             //We Can access protected Member from Derived Classes
            //Within the Same Assembly
            Console.WriteLine(age); //No-Compile Time Error
        }
    }
    public class AccessSpecifierClass3
    {
        public void Dispplay3()
        {
            //You cannot access the Private Member from the Non-Derived Classes
            //Within the Same Assembly
            AccessSpecifierClass1 obj = new AccessSpecifierClass1();
            //Console.WriteLine(obj.Id); //Compile Time Error
            //We Can access public Members from Non-Derived Classes
            //Within the Same Assembly
            Console.WriteLine(obj.name);
            //We Cannot access protected Member from Non-Derived Classes
            //Within the Same Assembly
            //Console.WriteLine(obj.age); //Compile Time Error
        }
    }
}