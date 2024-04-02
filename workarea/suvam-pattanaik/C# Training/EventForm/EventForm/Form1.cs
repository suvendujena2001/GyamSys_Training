using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventForm;
namespace EventForm
{
    
    public partial class Form1 : Form
    {
        Employee model = new Employee();

        TrainingDbEntities trainingDbEntities = new TrainingDbEntities();
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = trainingDbEntities.Employees.ToList();
            trainingDbEntities.SaveChanges();
 
        }


        private void button1_Click(object sender, EventArgs e)
        {
           // trainingDbEntities.SaveChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert data
            model.EmpNo = int.Parse(textBox1.Text);
            model.EmpName =textBox2.Text;
            model.Job = textBox3.Text;
            
            trainingDbEntities.Employees.Add(model);
            dataGridView1.DataSource = trainingDbEntities.Employees.ToList();
            trainingDbEntities.SaveChanges();





        }

        private void button4_Click(object sender, EventArgs e)
        {
            // delete data entry
            clear();
        }

        void clear()
        {
            EmpNo.Text=EmpName.Text=Job.Text=Manager.Text=JoiningDate.Text=Salary.Text=Bonus.Text= " ";
            button5.Text = "Save";
            button4.Enabled = false;
            model.EmpNo = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // update the row.
            if(dataGridView1.SelectedRows.Count > 0) { 
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int empNoToUpdate = Convert.ToInt32(selectedRow.Cells["EmpNo"].Value);

                Employee employeeToUpdate = trainingDbEntities.Employees.FirstOrDefault(emp
                    => emp.EmpNo == empNoToUpdate);

                if (employeeToUpdate != null)
                {
                    employeeToUpdate.EmpName = Convert.ToString(selectedRow.Cells["EmpName"].Value);
                    employeeToUpdate.Job = Convert.ToString(selectedRow.Cells["Job"].Value);

                    trainingDbEntities.SaveChanges();
                    MessageBox.Show("Record updated");
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("PLease select row");
            }
           
        }
    }
}
