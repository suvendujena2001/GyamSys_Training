using New_project.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_project
{
    public partial class Form1 : Form
    {

        My_ProjectEntities data = new My_ProjectEntities();

        private Employee selectedEmployee;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        public void Load_Data()
        {
            List<Employee> emp = data.Employees.ToList();
            dataGridView1.DataSource = emp;
        }

        // insert into the grid-view
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Emp_ID = Convert.ToInt32(txtEmpId.Text),
                Emp_Name = txtEmpName.Text,
                Job = txtJob.Text,
                Salary = Convert.ToInt32(txtSalary.Text),
            };
            data.Employees.Add(emp);
            data.SaveChanges();

            Load_Data();

            MessageBox.Show("Added successfully");

        }

        
        // update a particular record in grid-view
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.RowIndex < dataGridView1.Rows.Count-1) { 
            
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedEmployee = (Employee)row.DataBoundItem;
                txtEmpId.Text = selectedEmployee.Emp_ID.ToString();
                txtEmpName.Text = selectedEmployee.Emp_Name;
                txtJob.Text = selectedEmployee.Job;
                txtSalary.Text =selectedEmployee.Salary.ToString();
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(selectedEmployee!=null)
            {
                selectedEmployee.Emp_ID =Convert.ToInt32(txtEmpId.Text);
                selectedEmployee.Emp_Name = txtEmpName.Text;
                selectedEmployee.Job = txtJob.Text;
                selectedEmployee.Salary = Convert.ToInt32(txtSalary.Text);

                data.SaveChanges();

                Load_Data();

                selectedEmployee = null;
                txtEmpId.Clear();
                txtEmpName.Clear();
                txtJob.Clear();
                txtSalary.Clear();
            }
            else
            {
                MessageBox.Show("please select a row to update");
            }

            MessageBox.Show("updated successfully");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(selectedEmployee!=null)
            {
                data.Employees.Remove(selectedEmployee);

                data.SaveChanges();

                Load_Data();

                selectedEmployee = null;
                txtEmpId.Clear();
                txtEmpName.Clear();
                txtJob.Clear();
                txtSalary.Clear();

            }
            else
            {
                MessageBox.Show("Please select a row to delete !!");
            }

            MessageBox.Show("Deleted the record successfully!!");
        }

        private void ClearALLBtn_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();

            //data.SaveChanges();
            MessageBox.Show("Cleared successfully");


        }
       

        
    }
}
