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
    }
}
