using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitypractice.EntityModels;
using System.Data.Entity;
using System.Runtime.InteropServices;
namespace Entitypractice
{
    public partial class Form1 : Form
    {
        TrainingDbEntity tde = new TrainingDbEntity();
        
        
        public Form1()
        {
            InitializeComponent();
            
            List<Employee> source = tde.Employees.ToList();
            dataGridView1.DataSource = source;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tde.SaveChanges();
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                Nametb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Jobtb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Joiningtb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Depttb.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime joiningDate = DateTime.Parse(Joiningtb.Text);
            int currentYear = DateTime.Now.Year;
            int experience = currentYear - joiningDate.Year;
            Experiencetb.Text = experience.ToString();
            label3.Text = "years";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
