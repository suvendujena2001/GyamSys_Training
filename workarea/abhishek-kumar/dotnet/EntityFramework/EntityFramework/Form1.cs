using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.EntityModel;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        EntityDataModel obj = new EntityDataModel();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.SaveChanges();
            MessageBox.Show("Data has saved/display successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> list = obj.Employees.ToList();
            dataGridView1.DataSource = list;
        }

        
    }
}
