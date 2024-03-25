using System;

public class HelloWorld
{
    class Employee{
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TextDeduction = 0.1;
        double netSalary;
        
        public Employee(int Eid, string Ename, double Egrosspay){
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;
        }
        void CalculateSalary(){
            if(GrossPay >= 30000){
                netSalary = GrossPay - (TextDeduction * GrossPay);
                Console.WriteLine(netSalary);
            }
            else{
                 Console.WriteLine(GrossPay);
            }
        }
        public void showEmp(){
            this.CalculateSalary();
        }
    }
    public static void Main(string[] args)
    {
        Employee kalpana = new Employee(333,"Kalapana Panigrahi",21000);
        kalpana.showEmp();
    }
}