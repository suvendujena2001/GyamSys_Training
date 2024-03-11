using System;
using System.ComponentModel.DataAnnotations;
using MyApp1;
namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
       Address address = new Address("B1-3029", "BBSR", "Odisha");
       Employee employee = new Employee(1001, "Ramesh", address);
       employee.Display();

      // Cuboid cuboid=new Cuboid(2,3,4);
      // Console.WriteLine(cuboid.Volume());

      // Console.WriteLine("Transaction doing SBI Bank");
      // IBank sbi = AbstractionDemo.GetBankObject("SBI");
      // sbi.ValidateCard();
      // sbi.WithdrawMoney();
      // sbi.CheckBalanace();
      // sbi.BankTransfer();
      // sbi.MiniStatement();
      // Console.WriteLine("\nTransaction doing AXIX Bank");
      // IBank AXIX = AbstractionDemo.GetBankObject("AXIX");
      // AXIX.ValidateCard();
      // AXIX.WithdrawMoney();
      // AXIX.CheckBalanace();
      // AXIX.BankTransfer();
      // AXIX.MiniStatement();

      //  AccessSpecifierClass1 obj=new AccessSpecifierClass1();
      //  Console.WriteLine(obj.city);

      // DemoClass demoClass =new DemoClass();
      // demoClass.display();
      // AccessSpecifierClass2 asc2=new AccessSpecifierClass2();
      // asc2.Display2();

      // PropertyDemo PropertyDemo = new PropertyDemo();
      // //We cannot access the private data members
      // //So, using public properties (SET Accessor) we are setting 
      // //the values of private data members
      // PropertyDemo.EmpId = 101;
      // PropertyDemo.EmpName = "Pranaya";
      // //Using public properties (Get Accessor) we are Getting 
      // //the values of private data members
      // Console.WriteLine("PropertyDemo Details:");
      // Console.WriteLine("PropertyDemo id:" + PropertyDemo.EmpId);
      // Console.WriteLine("PropertyDemo name:" + PropertyDemo.EmpName);

      //  // we can call the add method directly or through class name
      // StaticDemo.Add(); //Calling Add Method using Class Name

      // // Mul() method is a Non-Static method
      // // We can call the non-static method using object only from a static method
      // StaticDemo obj = new StaticDemo();
      // obj.Mul(); //Calling Mul Method using Instance


      // DataTypes dataDisplay=new DataTypes();
      // dataDisplay.displayDataTypes();

      // TypeCasting typeCasting=new TypeCasting();
      // typeCasting.implicitDisplay();
      // typeCasting.explicitDisplay();

      // FunctionDemo functionDemo=new FunctionDemo();
      // functionDemo.add(5,29);
      // functionDemo.add(5, 29.1f);
      // functionDemo.add(5.1f, 29.1f);
      // functionDemo.add(5, 6,7);

      ////convert into integer type
      //int argument1 = Convert.ToInt32(args[3]);
      //Console.WriteLine("Argument in Integer Form : " + argument1);
      ////convert into double type
      //double argument2 = Convert.ToDouble(args[4]);
      //Console.WriteLine("Argument in Double Form : " + argument2);

      //Command line arguments
      //Console.WriteLine($"First Command Line Argument {args[0]}");
      //Console.WriteLine($"Second Command Line Argument {args[1]}");
      //Console.WriteLine($"Third Command Line Argument {args[2]}");
    }
  }

  public class DemoClass : AccessSpecifierClass1
  {
    public void display()
    {
      Console.WriteLine(age);
    }
  }
}