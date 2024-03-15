using PracticeForm.Entity_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.trainingDBDataSet.client);
            // TODO: This line of code loads data into the 'trainingDBDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.trainingDBDataSet.employee);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet1.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.trainingDBDataSet1.employee);
            // TODO: This line of code loads data into the 'trainingDBDataSet1.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.trainingDBDataSet1.client);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           TrainingDBEntities8 trainingDB=new TrainingDBEntities8();
            List<employee> employees = trainingDB.employees.ToList();
            comboBox1.DataSource = employees;
            comboBox1.DisplayMember = "empName";
            comboBox1.ValueMember = "empID";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView4.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();


            textBox1.Text = columnData.Sum().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView3.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();


            textBox2.Text = columnData.Sum().ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble((Convert.ToDouble(textBox2.Text) / Convert.ToInt32(textBox1.Text))));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
