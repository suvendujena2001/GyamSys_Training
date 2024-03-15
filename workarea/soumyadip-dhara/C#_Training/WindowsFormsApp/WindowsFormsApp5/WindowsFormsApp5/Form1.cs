using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.dataBase;
using WindowsFormsApp5.dataBase;

namespace WindowsFormsApp5
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
            label1.Text = "Employee Details:";
            label3.Text = "Department Details:";
            dataGridView1.GridColor = Color.Yellow;
            dataGridView2.GridColor = Color.Green;
            List<Employee> emp = obj.Employees.ToList();
            List<Department> dept= obj.Departments.ToList();
            dataGridView1.DataSource = emp;
            dataGridView2.DataSource = dept;
            obj.SaveChanges();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            ForeColor = Color.White;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Red;
            dataGridView2.ForeColor = Color.Blue;
        }

    }
}
