using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.dataBase;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Model1 obj=new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> employees = obj.Employees.ToList();
            dataGridView1.DataSource= employees;
            dataGridView1.ForeColor = Color.Black;
            obj.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            textBox1.Text = "";
            obj.SaveChanges();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n = 0;
                try {
                  n = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                    return;
                }
                Employee emp = obj.Employees.Where(x => x.EmpNo == n).FirstOrDefault();
                    if (emp != null)
                    {
                        dataGridView2.DataSource = new List<Employee> { emp };
                        dataGridView2.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("No employee found with EmpNo " + n);
                    }
                
            }   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White ;
            ForeColor = Color.Black;
            button1.ForeColor=Color.Black;
            label1.ForeColor=Color.White;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                 EmpNo = Convert.ToInt32(txtEmpId.Text),
                 EmpName = txtEmpName.Text,
                 Job = txtJob.Text,
                 Manager =Convert.ToInt32(txtManagerId.Text),
                 JoiningDate =dateTimePicker1.Value,
                 Salary = Convert.ToInt32(txtSalary.Text),
                 Bonus = Convert.ToInt32(txtBonus.Text),
                 DeptNo = Convert.ToInt32(txtDeptId.Text)
            };
            obj.Employees.Add(emp);
            obj.SaveChanges();
            MessageBox.Show("Data Added Successfully!");
            txtEmpId.Text = "";
            txtEmpName.Text = "";
            txtJob.Text = "";
            txtSalary.Text = "";
            txtBonus.Text = "";
            txtDeptId.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = "";
            txtEmpName.Text = "";
            txtJob.Text = "";
            txtSalary.Text = "";
            txtBonus.Text = "";
            txtDeptId.Text = "";
            txtManagerId.Text = "";
            dateTimePicker1.Value= DateTime.Now;
        }
    }
}
