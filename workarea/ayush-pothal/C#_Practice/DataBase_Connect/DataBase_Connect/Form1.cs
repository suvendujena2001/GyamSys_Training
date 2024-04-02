using DataBase_Connect.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Connect
{
    public partial class Form1 : Form
    {
        TrainingDbEntities trainingDbEntities = new TrainingDbEntities();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = trainingDbEntities.EMPLOYEE_TABLE.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trainingDbEntities.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDbDataSet.EMPLOYEE_TABLE' table. You can move, or remove it, as needed.
            this.eMPLOYEE_TABLETableAdapter.Fill(this.trainingDbDataSet.EMPLOYEE_TABLE);
            // TODO: This line of code loads data into the 'trainingDbDataSet.DEPT_TABLE' table. You can move, or remove it, as needed.
            this.dEPT_TABLETableAdapter.Fill(this.trainingDbDataSet.DEPT_TABLE);

        }
    }
}
