using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.model2;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        MyDataBaseEntities obj1=new MyDataBaseEntities();
        public Form2()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            List<Employee> list = obj1.Employees.ToList();
            dataGridView1.DataSource = list;
            List<Department> list1 = obj1.Departments.ToList();
            dataGridView2.DataSource = list1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                EMPID = Convert.ToInt32(EmployeeIdtxt.Text),
                EMPNAME = EmployeeNameTxt.Text,
                EMPDEPTID = Convert.ToInt32(EmployeeDepartmentIdTxt.Text),
                EMPSALARY = Convert.ToInt32(EmployeeSalaryTxt.Text)
            };
            obj1.Employees.Add(emp);
            obj1.SaveChanges();
            MessageBox.Show("Added succefully");
            EmployeeIdtxt.Text = "";
            EmployeeNameTxt.Text = "";
            EmployeeDepartmentIdTxt.Text = "";
            EmployeeSalaryTxt.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Department dep = new Department
            {
                DeptId = Convert.ToInt32(DepartmentIdTxt.Text),
                DeptName = DepartmentNameTxt.Text,
            };
            obj1.Departments.Add(dep);
            obj1.SaveChanges();
            MessageBox.Show("Added succefully");
            DepartmentIdTxt.Text = "";
            DepartmentNameTxt.Text = "";
                
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(deltxt.Text);
            var empdetails = from Employee in obj1.Employees where Employee.EMPID == id select Employee;

            foreach ( var emp in empdetails )
            {
                obj1.Employees.Remove(emp);
            }
            obj1.SaveChanges ();
            MessageBox.Show("Deleted");
            deltxt.Text = "";
        }


    }
}
