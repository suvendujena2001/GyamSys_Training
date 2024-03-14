using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        EntityFrameWork obj = new EntityFrameWork();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Employee> list = obj.Employees.ToList();
            dataGridView1.DataSource = list;

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "NationalIDNumber";


        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
