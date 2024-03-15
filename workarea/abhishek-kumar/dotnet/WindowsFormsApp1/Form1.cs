using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataModel obj = new DataModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> list = obj.Employees.ToList();
            dataGridView1.DataSource = list;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int n = 0;
                    try
                    {
                        n = Convert.ToInt32(textBox4.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Input");
                    }

                    Employee emp = obj.Employees.Where(x => x.EmpNo == n).FirstOrDefault();
                    if (emp != null)
                    {
                        dataGridView2.DataSource = new List<Employee> { emp };
                    }
                    else
                    {
                        MessageBox.Show($"No record is available for id{n}");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                EmpNo = Convert.ToInt32(textBox1.Text),
                EmpName = textBox2.Text,
                Salary = Convert.ToInt32 (textBox3.Text)
            };

            obj.Employees.Add(emp);
            obj.SaveChanges();
            MessageBox.Show("Data Added Successfully!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }


