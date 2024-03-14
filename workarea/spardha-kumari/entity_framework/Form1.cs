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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private TrainingDbDataSet db;
        public Form1()
        {
            InitializeComponent();
            db = new TrainingDbDataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource= db.Department.ToList();
            //dataGridView2.DataSource = db.Employees.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.trainingDbDataSet.Employee);
            // TODO: This line of code loads data into the 'trainingDbDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.trainingDbDataSet.Department);

        }
    }
}

