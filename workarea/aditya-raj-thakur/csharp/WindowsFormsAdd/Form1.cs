using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAdd.dataBase;

namespace WindowsFormsAdd
{
    public partial class Form1 : Form
    {
        Model1 obj=new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employees = obj.Employees.ToList();
            dataGridView1.DataSource = employees;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n = 0;
                try { 
                    n=Convert.ToInt32(txtSearch.Text);
                }
                catch {
                    MessageBox.Show("Invalid Input");
                }

                Employee emp=obj.Employees.Where(x=>x.EmpId == n).FirstOrDefault();
                if(emp != null)
                {
                    dataGridView2.DataSource = new List<Employee> { emp };
                }
                else
                {
                    MessageBox.Show($"No record is available for id{n}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            txtSearch.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                EmpId=Convert.ToInt32(txtID.Text),
                EmpName=txtEmpName.Text,
                Edesignation=txtdesignation.Text
            };

            obj.Employees.Add(emp);
            obj.SaveChanges();
            MessageBox.Show("Data Added Successfully!");
            txtID.Text = "";
            txtEmpName.Text = "";
            txtdesignation.Text = "";
        }
    }
}
